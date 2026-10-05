using System;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034C2 RID: 13506
	[Token(Token = "0x20034C2")]
	public class DynIllust : DynIllustBase
	{
		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0601585A RID: 88154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032D4")]
		public override SkeletonAnimation skeleton
		{
			[Token(Token = "0x601585A")]
			[Address(RVA = "0xE05230", Offset = "0xE03E30", VA = "0x180E05230", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0601585B RID: 88155 RVA: 0x0008C610 File Offset: 0x0008A810
		[Token(Token = "0x170032D5")]
		public override float playingActionDur
		{
			[Token(Token = "0x601585B")]
			[Address(RVA = "0xE05110", Offset = "0xE03D10", VA = "0x180E05110", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0601585C RID: 88156 RVA: 0x0008C628 File Offset: 0x0008A828
		[Token(Token = "0x170032D6")]
		public override float playingTime
		{
			[Token(Token = "0x601585C")]
			[Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0601585D RID: 88157 RVA: 0x0008C640 File Offset: 0x0008A840
		[Token(Token = "0x170032D7")]
		protected override bool actionDataInitialized
		{
			[Token(Token = "0x601585D")]
			[Address(RVA = "0xE05030", Offset = "0xE03C30", VA = "0x180E05030", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601585E RID: 88158 RVA: 0x0008C658 File Offset: 0x0008A858
		[Token(Token = "0x601585E")]
		[Address(RVA = "0xE048A0", Offset = "0xE034A0", VA = "0x180E048A0", Slot = "10")]
		protected override bool SupportNormalActionType(DynIllustAction action)
		{
			return default(bool);
		}

		// Token: 0x0601585F RID: 88159 RVA: 0x0008C670 File Offset: 0x0008A870
		[Token(Token = "0x601585F")]
		[Address(RVA = "0xE04780", Offset = "0xE03380", VA = "0x180E04780", Slot = "11")]
		public override float GetActionDur(DynIllustBase.DynIllustActionQuery action)
		{
			return 0f;
		}

		// Token: 0x06015860 RID: 88160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015860")]
		[Address(RVA = "0xE046D0", Offset = "0xE032D0", VA = "0x180E046D0", Slot = "17")]
		public override void ChangeAction(DynIllustBase.DynIllustActionQuery action, float loop)
		{
		}

		// Token: 0x06015861 RID: 88161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015861")]
		[Address(RVA = "0xE04910", Offset = "0xE03510", VA = "0x180E04910")]
		protected void _ApplyAnimation()
		{
		}

		// Token: 0x06015862 RID: 88162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015862")]
		[Address(RVA = "0xE04FB0", Offset = "0xE03BB0", VA = "0x180E04FB0")]
		public DynIllust()
		{
		}

		// Token: 0x06015863 RID: 88163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015863")]
		[Address(RVA = "0xE00710", Offset = "0xDFF310", VA = "0x180E00710")]
		private void <>xLuaBaseProxy_ChangeAction(DynIllustBase.DynIllustActionQuery P0, float P1)
		{
		}

		// Token: 0x04019CAD RID: 105645
		[Token(Token = "0x4019CAD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected SkeletonAnimation _skeleton;

		// Token: 0x04019CAE RID: 105646
		[Token(Token = "0x4019CAE")]
		[FieldOffset(Offset = "0xA8")]
		private Spine.Animation m_playingAnim;

		// Token: 0x04019CAF RID: 105647
		[Token(Token = "0x4019CAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skeleton;

		// Token: 0x04019CB0 RID: 105648
		[Token(Token = "0x4019CB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playingActionDur;

		// Token: 0x04019CB1 RID: 105649
		[Token(Token = "0x4019CB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_playingTime;

		// Token: 0x04019CB2 RID: 105650
		[Token(Token = "0x4019CB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_actionDataInitialized;

		// Token: 0x04019CB3 RID: 105651
		[Token(Token = "0x4019CB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SupportNormalActionType;

		// Token: 0x04019CB4 RID: 105652
		[Token(Token = "0x4019CB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActionDur;

		// Token: 0x04019CB5 RID: 105653
		[Token(Token = "0x4019CB5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeAction;

		// Token: 0x04019CB6 RID: 105654
		[Token(Token = "0x4019CB6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyAnimation;

		// Token: 0x04019CB7 RID: 105655
		[Token(Token = "0x4019CB7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
