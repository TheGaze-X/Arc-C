using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;

// Token: 0x02000028 RID: 40
[Token(Token = "0x2000028")]
[CreateAssetMenu(fileName = "TNodeBuffTemplateHolder", menuName = "TorappuNode/TNodeBuffTemplateHolder")]
[Serializable]
public class TNodeBuffTemplateHolder : ScriptableObject
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001B")]
	public List<TNodeBuffTemplate> templates
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x50E3A0", Offset = "0x50CFA0", VA = "0x18050E3A0")]
	public TNodeBuffTemplateHolder()
	{
	}

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Inspect(InspectorLevel.Debug)]
	private List<TNodeBuffTemplate> _templates;
}
