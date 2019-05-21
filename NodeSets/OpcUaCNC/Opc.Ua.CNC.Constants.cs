/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.CNC
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the CncInterfaceType_CncAxisList Object.
        /// </summary>
        public const uint CncInterfaceType_CncAxisList = 15001;

        /// <summary>
        /// The identifier for the CncInterface Object.
        /// </summary>
        public const uint CncInterface = 15002;

        /// <summary>
        /// The identifier for the CncInterface_CncAxisList Object.
        /// </summary>
        public const uint CncInterface_CncAxisList = 15003;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the CncComponentType ObjectType.
        /// </summary>
        public const uint CncComponentType = 1001;

        /// <summary>
        /// The identifier for the CncDriveType ObjectType.
        /// </summary>
        public const uint CncDriveType = 1003;

        /// <summary>
        /// The identifier for the CncAxisListType ObjectType.
        /// </summary>
        public const uint CncAxisListType = 1008;

        /// <summary>
        /// The identifier for the CncInterfaceType ObjectType.
        /// </summary>
        public const uint CncInterfaceType = 1007;

        /// <summary>
        /// The identifier for the CncAlarmType ObjectType.
        /// </summary>
        public const uint CncAlarmType = 15004;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the CncInterfaceType_CncAxisList Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType_CncAxisList = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterfaceType_CncAxisList, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterface, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterface_CncAxisList Object.
        /// </summary>
        public static readonly ExpandedNodeId CncInterface_CncAxisList = new ExpandedNodeId(Opc.Ua.CNC.Objects.CncInterface_CncAxisList, Opc.Ua.CNC.Namespaces.OpcUaCNC);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the CncComponentType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncComponentType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncComponentType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncDriveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncDriveType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncDriveType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncAxisListType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncAxisListType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncAxisListType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncInterfaceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncInterfaceType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncInterfaceType, Opc.Ua.CNC.Namespaces.OpcUaCNC);

        /// <summary>
        /// The identifier for the CncAlarmType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CncAlarmType = new ExpandedNodeId(Opc.Ua.CNC.ObjectTypes.CncAlarmType, Opc.Ua.CNC.Namespaces.OpcUaCNC);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CncAlarmType component.
        /// </summary>
        public const string CncAlarmType = "CncAlarmType";

        /// <summary>
        /// The BrowseName for the CncAxisList component.
        /// </summary>
        public const string CncAxisList = "CncAxisList";

        /// <summary>
        /// The BrowseName for the CncAxisListType component.
        /// </summary>
        public const string CncAxisListType = "CncAxisListType";

        /// <summary>
        /// The BrowseName for the CncComponentType component.
        /// </summary>
        public const string CncComponentType = "CncComponentType";

        /// <summary>
        /// The BrowseName for the CncDriveType component.
        /// </summary>
        public const string CncDriveType = "CncDriveType";

        /// <summary>
        /// The BrowseName for the CncInterface component.
        /// </summary>
        public const string CncInterface = "CncInterface";

        /// <summary>
        /// The BrowseName for the CncInterfaceType component.
        /// </summary>
        public const string CncInterfaceType = "CncInterfaceType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUaCNC namespace (.NET code namespace is 'Opc.Ua.CNC').
        /// </summary>
        public const string OpcUaCNC = "http://www.opcfoundation.org/CNC/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}
