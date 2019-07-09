// ***START***
/******************************************************************************
** $Id$
**
** Copyright (C) 2006-2008 ascolab GmbH. All Rights Reserved.
** Web: http://www.ascolab.com
**
** This program is free software; you can redistribute it and/or
** modify it under the terms of the GNU General Public License
** as published by the Free Software Foundation; either version 2
** of the License, or (at your option) any later version.
**
** This file is provided AS IS with NO WARRANTY OF ANY KIND, INCLUDING THE
** WARRANTY OF DESIGN, MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
**
** Project: OpcUa Wireshark Plugin
**
** Description: Parser type definitions.
**
** DON'T MODIFY THIS FILE!
**
******************************************************************************/

#ifdef HAVE_CONFIG_H
# include "config.h"
#endif

#include <gmodule.h>
#include <epan/packet.h>

/* declare service parser function prototype */
typedef void (*fctServiceParser)(proto_tree *tree, tvbuff_t *tvb, gint *pOffset);
/* declare enum parser function prototype */
typedef void (*fctEnumParser)(proto_tree *tree, tvbuff_t *tvb, gint *pOffset);
/* declare type parser function prototype */
typedef void (*fctComplexTypeParser)(proto_tree *tree, tvbuff_t *tvb, gint *pOffset, char *szFieldName);
/* declare type parser function prototype */
typedef void (*fctSimpleTypeParser)(proto_tree *tree, tvbuff_t *tvb, gint *pOffset, int hfIndex);

typedef struct _ParserEntry
{
    int iRequestId;
    fctServiceParser pParser;
} ParserEntry;

// ***END***