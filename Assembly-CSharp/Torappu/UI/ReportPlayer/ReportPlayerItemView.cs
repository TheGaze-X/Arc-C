using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ReportPlayer
{
	// Token: 0x020046DE RID: 18142
	[Token(Token = "0x20046DE")]
	public class ReportPlayerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x0601B812 RID: 112658 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B813 RID: 112659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700417B")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x601B812")]
			[Address(RVA = "0x14D0350", Offset = "0x14CEF50", VA = "0x1814D0350")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B813")]
			[Address(RVA = "0x14D03B0", Offset = "0x14CEFB0", VA = "0x1814D03B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B814 RID: 112660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B814")]
		[Address(RVA = "0x14D0180", Offset = "0x14CED80", VA = "0x1814D0180")]
		public void Render(ReportPlayerItemModel reportItemModel, bool isSelectMax, bool isSelect)
		{
		}

		// Token: 0x0601B815 RID: 112661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B815")]
		[Address(RVA = "0x14D0090", Offset = "0x14CEC90", VA = "0x1814D0090")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0601B816 RID: 112662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B816")]
		[Address(RVA = "0x14D02F0", Offset = "0x14CEEF0", VA = "0x1814D02F0")]
		public ReportPlayerItemView()
		{
		}

		// Token: 0x04023A05 RID: 145925
		[Token(Token = "0x4023A05")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _iconSelectGO;

		// Token: 0x04023A06 RID: 145926
		[Token(Token = "0x4023A06")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconUnselectGO;

		// Token: 0x04023A07 RID: 145927
		[Token(Token = "0x4023A07")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _iconSelectFullGO;

		// Token: 0x04023A08 RID: 145928
		[Token(Token = "0x4023A08")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04023A09 RID: 145929
		[Token(Token = "0x4023A09")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04023A0A RID: 145930
		[Token(Token = "0x4023A0A")]
		[FieldOffset(Offset = "0x40")]
		private ReportPlayerItemModel m_reportItemModel;

		// Token: 0x04023A0C RID: 145932
		[Token(Token = "0x4023A0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x04023A0D RID: 145933
		[Token(Token = "0x4023A0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x04023A0E RID: 145934
		[Token(Token = "0x4023A0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023A0F RID: 145935
		[Token(Token = "0x4023A0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04023A10 RID: 145936
		[Token(Token = "0x4023A10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
