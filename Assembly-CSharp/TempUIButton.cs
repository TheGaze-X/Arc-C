using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
public class TempUIButton : MonoBehaviour
{
	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x50E430", Offset = "0x50D030", VA = "0x18050E430")]
	public void Init(string scriptKey)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
	public TempUIButton()
	{
	}

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _text;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x20")]
	private string m_scriptKey;
}
