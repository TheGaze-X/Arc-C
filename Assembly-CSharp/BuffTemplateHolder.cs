using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
[CreateAssetMenu(menuName = "Torappu/DB/BuffTemplate/BuffTemplateHolder")]
[Serializable]
public class BuffTemplateHolder : ScriptableObject
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001A")]
	public List<BuffTemplate> templates
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
	public BuffTemplateHolder()
	{
	}

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<BuffTemplate> _templates;
}
