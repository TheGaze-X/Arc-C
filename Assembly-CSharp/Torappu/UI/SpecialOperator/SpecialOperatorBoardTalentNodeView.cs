using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003EAA RID: 16042
	[Token(Token = "0x2003EAA")]
	public class SpecialOperatorBoardTalentNodeView : SpecialOperatorPointViewBase, SpecialOperatorPointViewBase.ISelectAnchorHolder
	{
		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x06018E5E RID: 101982 RVA: 0x0009C5B8 File Offset: 0x0009A7B8
		[Token(Token = "0x17003B64")]
		public override SpecialOperatorPointViewType viewType
		{
			[Token(Token = "0x6018E5E")]
			[Address(RVA = "0x11929D0", Offset = "0x11915D0", VA = "0x1811929D0", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018E5F RID: 101983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E5F")]
		[Address(RVA = "0x1192040", Offset = "0x1190C40", VA = "0x181192040", Slot = "7")]
		public RectTransform GetSelectAnchor()
		{
			return null;
		}

		// Token: 0x06018E60 RID: 101984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E60")]
		[Address(RVA = "0x11921B0", Offset = "0x1190DB0", VA = "0x1811921B0", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06018E61 RID: 101985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E61")]
		[Address(RVA = "0x11927C0", Offset = "0x11913C0", VA = "0x1811927C0")]
		private void _RenderNewPart(SpecialOperatorBoardTalentNode talentModel)
		{
		}

		// Token: 0x06018E62 RID: 101986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E62")]
		[Address(RVA = "0x11926B0", Offset = "0x11912B0", VA = "0x1811926B0")]
		private void _RenderLvlupPart(SpecialOperatorBoardTalentNode talentModel)
		{
		}

		// Token: 0x06018E63 RID: 101987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E63")]
		[Address(RVA = "0x11920C0", Offset = "0x1190CC0", VA = "0x1811920C0")]
		public void OnClick()
		{
		}

		// Token: 0x06018E64 RID: 101988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E64")]
		[Address(RVA = "0x1192640", Offset = "0x1191240", VA = "0x181192640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E65 RID: 101989 RVA: 0x0009C5D0 File Offset: 0x0009A7D0
		[Token(Token = "0x6018E65")]
		[Address(RVA = "0x11925A0", Offset = "0x11911A0", VA = "0x1811925A0")]
		private Color _GetTalentBgColor(PlayerSpecialOperatorNode.State state)
		{
			return default(Color);
		}

		// Token: 0x06018E66 RID: 101990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E66")]
		[Address(RVA = "0x1192930", Offset = "0x1191530", VA = "0x181192930")]
		public SpecialOperatorBoardTalentNodeView()
		{
		}

		// Token: 0x06018E67 RID: 101991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E67")]
		[Address(RVA = "0x118ED40", Offset = "0x118D940", VA = "0x18118ED40")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0401EB64 RID: 125796
		[Token(Token = "0x401EB64")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newPart;

		// Token: 0x0401EB65 RID: 125797
		[Token(Token = "0x401EB65")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _newBgImg;

		// Token: 0x0401EB66 RID: 125798
		[Token(Token = "0x401EB66")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _lockedBgColor;

		// Token: 0x0401EB67 RID: 125799
		[Token(Token = "0x401EB67")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _unlockedBgColor;

		// Token: 0x0401EB68 RID: 125800
		[Token(Token = "0x401EB68")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _talentNameText;

		// Token: 0x0401EB69 RID: 125801
		[Token(Token = "0x401EB69")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _lvlupPart;

		// Token: 0x0401EB6A RID: 125802
		[Token(Token = "0x401EB6A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lvlupUnlockPart;

		// Token: 0x0401EB6B RID: 125803
		[Token(Token = "0x401EB6B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _lvlupLockPart;

		// Token: 0x0401EB6C RID: 125804
		[Token(Token = "0x401EB6C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _lvlupNoticeText;

		// Token: 0x0401EB6D RID: 125805
		[Token(Token = "0x401EB6D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _selectAnchor;

		// Token: 0x0401EB6E RID: 125806
		[Token(Token = "0x401EB6E")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0401EB6F RID: 125807
		[Token(Token = "0x401EB6F")]
		[FieldOffset(Offset = "0x98")]
		private string m_nodeId;

		// Token: 0x0401EB70 RID: 125808
		[Token(Token = "0x401EB70")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EB71 RID: 125809
		[Token(Token = "0x401EB71")]
		[FieldOffset(Offset = "0xB0")]
		private SpecialOperatorBoardTalentNode m_cachedTalentNode;

		// Token: 0x0401EB72 RID: 125810
		[Token(Token = "0x401EB72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0401EB73 RID: 125811
		[Token(Token = "0x401EB73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSelectAnchor;

		// Token: 0x0401EB74 RID: 125812
		[Token(Token = "0x401EB74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401EB75 RID: 125813
		[Token(Token = "0x401EB75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderNewPart;

		// Token: 0x0401EB76 RID: 125814
		[Token(Token = "0x401EB76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderLvlupPart;

		// Token: 0x0401EB77 RID: 125815
		[Token(Token = "0x401EB77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401EB78 RID: 125816
		[Token(Token = "0x401EB78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EB79 RID: 125817
		[Token(Token = "0x401EB79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetTalentBgColor;

		// Token: 0x0401EB7A RID: 125818
		[Token(Token = "0x401EB7A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
