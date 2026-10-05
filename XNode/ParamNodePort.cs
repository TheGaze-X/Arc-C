using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using XNode;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class ParamNodePort : NodePort
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000001")]
	public FieldInfo paramFieldInfo
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000002")]
	public object param
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000003")]
	public string labelText
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x5BDC890", Offset = "0x5BDB490", VA = "0x185BDC890")]
	public ParamNodePort(string fieldName, string labelText, Type type, NodePort.IO direction, Node.ConnectionType connectionType, Node.TypeConstraint typeConstraint, Node node, FieldInfo field, object param)
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string m_labelText;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x50")]
	private FieldInfo m_paramFieldInfo;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x58")]
	private object m_param;
}
