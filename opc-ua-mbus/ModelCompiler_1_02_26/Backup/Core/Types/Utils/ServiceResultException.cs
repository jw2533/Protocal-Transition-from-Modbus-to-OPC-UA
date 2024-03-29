/* ========================================================================
 * Copyright (c) 2005-2011 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Reciprocal Community License ("RCL") Version 1.00
 *
 * Unless explicitly acquired and licensed from Licensor under another
 * license, the contents of this file are subject to the Reciprocal
 * Community License ("RCL") Version 1.00, or subsequent versions
 * as allowed by the RCL, and You may not copy or use this file in either
 * source code or executable form, except in compliance with the terms and
 * conditions of the RCL.
 *
 * All software distributed under the RCL is provided strictly on an
 * "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED,
 * AND LICENSOR HEREBY DISCLAIMS ALL SUCH WARRANTIES, INCLUDING WITHOUT
 * LIMITATION, ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE, QUIET ENJOYMENT, OR NON-INFRINGEMENT. See the RCL for specific
 * language governing rights and limitations under the RCL.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/RCL/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.ServiceModel;

namespace Opc.Ua
{
	/// <summary>
	/// An exception thrown when a UA defined error occurs.
	/// </summary>
    [Serializable]
	public class ServiceResultException : Exception
	{
		#region Constructors
		/// <summary>
		/// The default constructor.
		/// </summary>
		public ServiceResultException() : base(Strings.DefaultMessage)
		{
            m_status = StatusCodes.Bad;

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0}", m_status);
            }
		}

		/// <summary>
		/// Initializes the exception with a message.
		/// </summary>
		public ServiceResultException(string message) : base(message)
		{
            m_status = StatusCodes.Bad;

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0} {1}", m_status, message);
            }
		}

		/// <summary>
		/// Initializes the exception with a message and an exception.
		/// </summary>
		public ServiceResultException(Exception e, uint defaultCode) : base(e.Message, e)
		{
            m_status = ServiceResult.Create(e, defaultCode, String.Empty);

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0} {1} {2}", m_status, e.GetType().Name, e.Message);
            }
		}

		/// <summary>
		/// Initializes the exception with a message and an exception.
		/// </summary>
		public ServiceResultException(string message, Exception e) : base(message, e)
		{
            m_status = StatusCodes.Bad;

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0} {1} {2}", m_status, e.GetType().Name, message);
            }
		}

		/// <summary>
		/// Initializes the exception with a status code.
		/// </summary>
		public ServiceResultException(uint statusCode) : base(GetMessage(statusCode))
		{
			m_status = new ServiceResult(statusCode);

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0}", m_status);
            }
		}

		/// <summary>
		/// Initializes the exception with a status code and a message.
		/// </summary>
		public ServiceResultException(uint statusCode, string message) : base(message)
		{
            m_status = new ServiceResult(statusCode, message);

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0} {1}", m_status, message);
            }
		}

		/// <summary>
		/// Initializes the exception with a status code and an inner exception.
		/// </summary>
		public ServiceResultException(uint statusCode, Exception e) : base(GetMessage(statusCode), e)
		{
            m_status = new ServiceResult(statusCode, e);

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0} {1} {2}", m_status, e.GetType().Name, e.Message);
            }
		}

		/// <summary>
		/// Initializes the exception with a status code, a message and an inner exception.
		/// </summary>
		public ServiceResultException(uint statusCode, string message, Exception e) : base(message, e)
		{
            m_status = new ServiceResult(statusCode, message, e);

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0} {1} {2}", m_status, e.GetType().Name, message);
            }
		}

		/// <summary>
		/// Initializes the exception with a Result object.
		/// </summary>
		public ServiceResultException(ServiceResult status) : base(GetMessage(status))
		{
			if (status != null)
			{
				m_status = status;
			}
			else
			{
				m_status = new ServiceResult(StatusCodes.Bad);
            }

            if ((Utils.TraceMask & Utils.TraceMasks.StackTrace) != 0)
            {
                Utils.Trace(Utils.TraceMasks.StackTrace, "***EXCEPTION*** {0}", m_status);
            }
		}
		#endregion

		#region Public Properties
		/// <summary>
		/// The identifier for the status code.
		/// </summary>
		public uint StatusCode
		{
			get { return m_status.Code; }
		}

		/// <summary>
		/// The namespace that qualifies symbolic identifier.
		/// </summary>
		public string NamespaceUri
		{
			get { return m_status.NamespaceUri; }
		}

		/// <summary>
		/// The qualified name of the symbolic identifier associated with the status code.
		/// </summary>
		public string SymbolicId
		{
			get { return m_status.SymbolicId; }
		}

		/// <summary>
		/// The localized description for the status code.
		/// </summary>
		public LocalizedText LocalizedText
		{
			get { return m_status.LocalizedText; }
		}

		/// <summary>
		/// Additional diagnostic/debugging information associated with the operation.
		/// </summary>
		public string AdditionalInfo
		{
			get { return m_status.AdditionalInfo; }
		}

		/// <summary>
		/// Returns the status result associated with the exception.
		/// </summary>
		public ServiceResult Result
		{
			get { return m_status; }
		}

		/// <summary>
		/// Nested error information.
		/// </summary>
		public ServiceResult InnerResult
		{
			get { return m_status.InnerResult;  }
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Returns a formatted string with the contents of exeception.
		/// </summary>
		public string ToLongString()
		{
			StringBuilder buffer = new StringBuilder();

			buffer.Append(Message);
			buffer.Append("\r\n");
			buffer.Append(m_status.ToLongString());

			return buffer.ToString();
		}
		#endregion

		#region Static Interface
        /// <summary>
        /// Creates a new instance of a ServiceResultException
        /// </summary>
        public static ServiceResultException Create(uint code, string format, params object[] args)
        {
            if (format == null)
            {
                return new ServiceResultException(code);
            }

            return new ServiceResultException(code, Utils.Format(format, args));
        }

        /// <summary>
        /// Creates a new instance of a ServiceResultException
        /// </summary>
        public static ServiceResultException Create(uint code, Exception e, string format, params object[] args)
        {
            if (format == null)
            {
                return new ServiceResultException(code, e);
            }

            return new ServiceResultException(code, Utils.Format(format, args), e);
        }

        /// <summary>
        /// Creates a new instance of a ServiceResultException
        /// </summary>
        public static ServiceResultException Create(StatusCode code, int index, DiagnosticInfoCollection diagnosticInfos, IList<string> stringTable)
        {
            return new ServiceResultException(new ServiceResult(code, index, diagnosticInfos, stringTable));
        }
        #endregion

        #region Private Methods
        /// <summary>
		/// Extracts an exception message from a Result object.
		/// </summary>
		private static string GetMessage(ServiceResult status)
		{
			if (status == null)
			{
				return Strings.DefaultMessage;
			}

			if (!LocalizedText.IsNullOrEmpty(status.LocalizedText))
			{
				return status.LocalizedText.Text;
			}

			return status.ToString();
		}
		#endregion

		#region Private Fields
		private ServiceResult m_status;
		#endregion

		#region Private Constants
		/// <summary>
		/// Wraps string constants defined in the class.
		/// </summary>
		private static class Strings
		{
            public const string DefaultMessage = "A UA specific error occurred.";
		}
		#endregion

        #region ISerializable Members
        #if !SILVERLIGHT
		/// <summary>
		/// Initializes the object from a stream.
		/// </summary>
		protected ServiceResultException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
            throw new NotImplementedException("The method or operation is not implemented.");
		}

        /// <summary>
        /// Writes the object to the stream.
        /// </summary>
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            throw new NotImplementedException("The method or operation is not implemented.");
        }
        #endif
        #endregion
    }
}
