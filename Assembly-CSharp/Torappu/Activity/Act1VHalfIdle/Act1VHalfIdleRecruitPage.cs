using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077E3 RID: 30691
	[Token(Token = "0x20077E3")]
	public class Act1VHalfIdleRecruitPage : StateEnginePage, IDialogMgrHolder
	{
		// Token: 0x170064CC RID: 25804
		// (get) Token: 0x0602B10B RID: 176395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064CC")]
		public string actId
		{
			[Token(Token = "0x602B10B")]
			[Address(RVA = "0x26DFA10", Offset = "0x26DE610", VA = "0x1826DFA10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170064CD RID: 25805
		// (get) Token: 0x0602B10C RID: 176396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064CD")]
		public string gachaPoolId
		{
			[Token(Token = "0x602B10C")]
			[Address(RVA = "0x26DFAE0", Offset = "0x26DE6E0", VA = "0x1826DFAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B10D RID: 176397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B10D")]
		[Address(RVA = "0x26DF8F0", Offset = "0x26DE4F0", VA = "0x1826DF8F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B10E RID: 176398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B10E")]
		[Address(RVA = "0x26DF720", Offset = "0x26DE320", VA = "0x1826DF720", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0602B10F RID: 176399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B10F")]
		[Address(RVA = "0x26DF780", Offset = "0x26DE380", VA = "0x1826DF780", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602B110 RID: 176400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B110")]
		[Address(RVA = "0x26DF9B0", Offset = "0x26DE5B0", VA = "0x1826DF9B0")]
		public Act1VHalfIdleRecruitPage()
		{
		}

		// Token: 0x0602B111 RID: 176401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B111")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403E378 RID: 254840
		[Token(Token = "0x403E378")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403E379 RID: 254841
		[Token(Token = "0x403E379")]
		[FieldOffset(Offset = "0xF8")]
		private Act1VHalfIdleRecruitPage.Param m_param;

		// Token: 0x0403E37A RID: 254842
		[Token(Token = "0x403E37A")]
		[FieldOffset(Offset = "0x100")]
		private DataBundle m_savedInst;

		// Token: 0x0403E37B RID: 254843
		[Token(Token = "0x403E37B")]
		[FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0403E37C RID: 254844
		[Token(Token = "0x403E37C")]
		[FieldOffset(Offset = "0x110")]
		private bool m_inited;

		// Token: 0x0403E37D RID: 254845
		[Token(Token = "0x403E37D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403E37E RID: 254846
		[Token(Token = "0x403E37E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gachaPoolId;

		// Token: 0x0403E37F RID: 254847
		[Token(Token = "0x403E37F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E380 RID: 254848
		[Token(Token = "0x403E380")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0403E381 RID: 254849
		[Token(Token = "0x403E381")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403E382 RID: 254850
		[Token(Token = "0x403E382")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077E4 RID: 30692
		[Token(Token = "0x20077E4")]
		public class Param
		{
			// Token: 0x0602B112 RID: 176402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B112")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403E383 RID: 254851
			[Token(Token = "0x403E383")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E384 RID: 254852
			[Token(Token = "0x403E384")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;
		}
	}
}
