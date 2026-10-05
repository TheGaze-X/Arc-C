using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004067 RID: 16487
	[Token(Token = "0x2004067")]
	public class SandboxV2AdminMainTypeSelectorWrapper<TypeEnum> : MonoBehaviour, IHotfixable where TypeEnum : struct, IComparable, IConvertible, IFormattable
	{
		// Token: 0x14000084 RID: 132
		// (add) Token: 0x0601980B RID: 104459 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0601980C RID: 104460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000084")]
		public event Action<TypeEnum> eTypeSelectChanged
		{
			[Token(Token = "0x601980B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x601980C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0601980D RID: 104461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601980D")]
		public void Init(SandboxV2AdminMainTypeSelector selectorPrefab, Color selectedColor, IList<SandboxV2AdminMainTypeDefine<TypeEnum>> typeList, Transform root)
		{
		}

		// Token: 0x0601980E RID: 104462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601980E")]
		private void _EventSelectChanged(int idx)
		{
		}

		// Token: 0x0601980F RID: 104463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601980F")]
		public void SetSelectType(TypeEnum t)
		{
		}

		// Token: 0x06019810 RID: 104464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019810")]
		public SandboxV2AdminMainTypeSelectorWrapper()
		{
		}

		// Token: 0x0401FC98 RID: 130200
		[Token(Token = "0x401FC98")]
		[FieldOffset(Offset = "0x0")]
		private SandboxV2AdminMainTypeSelector m_selector;

		// Token: 0x0401FC99 RID: 130201
		[Token(Token = "0x401FC99")]
		[FieldOffset(Offset = "0x0")]
		private IList<SandboxV2AdminMainTypeDefine<TypeEnum>> m_typeList;

		// Token: 0x0401FC9B RID: 130203
		[Token(Token = "0x401FC9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eTypeSelectChanged;

		// Token: 0x0401FC9C RID: 130204
		[Token(Token = "0x401FC9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_remove_eTypeSelectChanged;

		// Token: 0x0401FC9D RID: 130205
		[Token(Token = "0x401FC9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401FC9E RID: 130206
		[Token(Token = "0x401FC9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EventSelectChanged;

		// Token: 0x0401FC9F RID: 130207
		[Token(Token = "0x401FC9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSelectType;

		// Token: 0x0401FCA0 RID: 130208
		[Token(Token = "0x401FCA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
