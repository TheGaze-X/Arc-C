using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200386B RID: 14443
	[Token(Token = "0x200386B")]
	public class UITipsHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016DEA RID: 93674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DEA")]
		[Address(RVA = "0xF68100", Offset = "0xF66D00", VA = "0x180F68100")]
		public void ResetCategory(TipData.Category category)
		{
		}

		// Token: 0x06016DEB RID: 93675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DEB")]
		[Address(RVA = "0xF67FC0", Offset = "0xF66BC0", VA = "0x180F67FC0")]
		public void RefreshTips()
		{
		}

		// Token: 0x06016DEC RID: 93676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DEC")]
		[Address(RVA = "0xF68090", Offset = "0xF66C90", VA = "0x180F68090")]
		public void ResetCandiates(List<TipData> candiates)
		{
		}

		// Token: 0x06016DED RID: 93677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DED")]
		[Address(RVA = "0xF68480", Offset = "0xF67080", VA = "0x180F68480")]
		private void _RefreshTips(bool force, List<TipData> candiates)
		{
		}

		// Token: 0x06016DEE RID: 93678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DEE")]
		[Address(RVA = "0xF68410", Offset = "0xF67010", VA = "0x180F68410")]
		private void Start()
		{
		}

		// Token: 0x06016DEF RID: 93679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DEF")]
		[Address(RVA = "0xF681F0", Offset = "0xF66DF0", VA = "0x180F681F0", Slot = "4")]
		protected virtual void SetTips(List<TipData> candiates)
		{
		}

		// Token: 0x06016DF0 RID: 93680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DF0")]
		[Address(RVA = "0xF68540", Offset = "0xF67140", VA = "0x180F68540")]
		public UITipsHolder()
		{
		}

		// Token: 0x0401B95D RID: 112989
		[Token(Token = "0x401B95D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Text[] _tipsText;

		// Token: 0x0401B95E RID: 112990
		[Token(Token = "0x401B95E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TipData.Category _category;

		// Token: 0x0401B95F RID: 112991
		[Token(Token = "0x401B95F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected bool _showOnStart;

		// Token: 0x0401B960 RID: 112992
		[Token(Token = "0x401B960")]
		[FieldOffset(Offset = "0x25")]
		private bool m_isDirty;

		// Token: 0x0401B961 RID: 112993
		[Token(Token = "0x401B961")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ResetCategory;

		// Token: 0x0401B962 RID: 112994
		[Token(Token = "0x401B962")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshTips;

		// Token: 0x0401B963 RID: 112995
		[Token(Token = "0x401B963")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetCandiates;

		// Token: 0x0401B964 RID: 112996
		[Token(Token = "0x401B964")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshTips;

		// Token: 0x0401B965 RID: 112997
		[Token(Token = "0x401B965")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B966 RID: 112998
		[Token(Token = "0x401B966")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetTips;

		// Token: 0x0401B967 RID: 112999
		[Token(Token = "0x401B967")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
