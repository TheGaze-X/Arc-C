using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200667E RID: 26238
	[Token(Token = "0x200667E")]
	public class HandBookInfoStageSkillSelectState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x06025AB5 RID: 154293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AB5")]
		[Address(RVA = "0x20944E0", Offset = "0x20930E0", VA = "0x1820944E0")]
		public void StartBattle()
		{
		}

		// Token: 0x06025AB6 RID: 154294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025AB6")]
		[Address(RVA = "0x2094060", Offset = "0x2092C60", VA = "0x182094060", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025AB7 RID: 154295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AB7")]
		[Address(RVA = "0x20942E0", Offset = "0x2092EE0", VA = "0x1820942E0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06025AB8 RID: 154296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AB8")]
		[Address(RVA = "0x20940C0", Offset = "0x2092CC0", VA = "0x1820940C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025AB9 RID: 154297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AB9")]
		[Address(RVA = "0x20948A0", Offset = "0x20934A0", VA = "0x1820948A0")]
		private void _SelectSkill(int idx)
		{
		}

		// Token: 0x06025ABA RID: 154298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ABA")]
		[Address(RVA = "0x20946C0", Offset = "0x20932C0", VA = "0x1820946C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025ABB RID: 154299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ABB")]
		[Address(RVA = "0x2094A00", Offset = "0x2093600", VA = "0x182094A00")]
		public HandBookInfoStageSkillSelectState()
		{
		}

		// Token: 0x06025ABC RID: 154300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ABC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04034ECE RID: 216782
		[Token(Token = "0x4034ECE")]
		[NonSerialized]
		public const int ON_SKILL_SELECT = 1;

		// Token: 0x04034ECF RID: 216783
		[Token(Token = "0x4034ECF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookInfoStageSkillSelectView _view;

		// Token: 0x04034ED0 RID: 216784
		[Token(Token = "0x4034ED0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04034ED1 RID: 216785
		[Token(Token = "0x4034ED1")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04034ED2 RID: 216786
		[Token(Token = "0x4034ED2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x04034ED3 RID: 216787
		[Token(Token = "0x4034ED3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034ED4 RID: 216788
		[Token(Token = "0x4034ED4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04034ED5 RID: 216789
		[Token(Token = "0x4034ED5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034ED6 RID: 216790
		[Token(Token = "0x4034ED6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SelectSkill;

		// Token: 0x04034ED7 RID: 216791
		[Token(Token = "0x4034ED7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034ED8 RID: 216792
		[Token(Token = "0x4034ED8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
