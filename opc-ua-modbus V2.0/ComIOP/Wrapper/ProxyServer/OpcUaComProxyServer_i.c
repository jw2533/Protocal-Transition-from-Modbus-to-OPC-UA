

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 8.00.0603 */
/* at Fri Sep 15 12:51:51 2017
 */
/* Compiler settings for OpcUaComProxyServer.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.00.0603 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, LIBID_OpcUaComProxyServerLib,0xD5A99E65,0x5B06,0x4990,0xA3,0xDE,0xFA,0xC1,0x3F,0x72,0x43,0x1D);


MIDL_DEFINE_GUID(CLSID, CLSID_ComDaProxyServer,0xB25384BD,0xD0DD,0x4d4d,0x80,0x5C,0x6E,0x9F,0x30,0x9F,0x27,0xC1);


MIDL_DEFINE_GUID(CLSID, CLSID_ComAeProxyServer,0x4DF1784D,0x085A,0x403d,0xAF,0x8A,0xB1,0x40,0x63,0x9B,0x10,0xB3);


MIDL_DEFINE_GUID(CLSID, CLSID_ComAe2ProxyServer,0x4DF1784C,0x085A,0x403d,0xAF,0x8A,0xB1,0x40,0x63,0x9B,0x10,0xB3);


MIDL_DEFINE_GUID(CLSID, CLSID_ComHdaProxyServer,0x2DA58B69,0x2D85,0x4de0,0xA9,0x34,0x77,0x51,0x32,0x21,0x32,0xE2);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



