﻿/*
 *  Firebird ADO.NET Data provider for .NET and Mono 
 * 
 *     The contents of this file are subject to the Initial 
 *     Developer's Public License Version 1.0 (the "License"); 
 *     you may not use this file except in compliance with the 
 *     License. You may obtain a copy of the License at 
 *     http://www.firebirdsql.org/index.php?op=doc&id=idpl
 *
 *     Software distributed under the License is distributed on 
 *     an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either 
 *     express or implied.  See the License for the specific 
 *     language governing rights and limitations under the License.
 * 
 *  Copyright (c) 2008 Jiri Cincura (jiri@cincura.net)
 *  All Rights Reserved.
 */

using System;
using System.Collections.Generic;

namespace FirebirdSql.Data.FirebirdClient
{
    public struct FbTransactionOptions
    {
        private short? _waitTimeout;
        public short? WaitTimeout
        {
            get { return _waitTimeout; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("The property value assigned is less than 1.");
                
                _waitTimeout = value;
            }
        }

        public FbTransactionBehavior TransactionBehavior { get; set; }

		public IDictionary<string, FbTransactionBehavior> LockTables { get; set; }
    }
}
