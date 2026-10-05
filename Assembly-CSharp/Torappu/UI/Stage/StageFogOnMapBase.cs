using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006960 RID: 26976
	[Token(Token = "0x2006960")]
	public abstract class StageFogOnMapBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x060269C0 RID: 158144
		[Token(Token = "0x60269C0")]
		public abstract void RenderView(StageFogOnMapBase.Param renderParam);

		// Token: 0x060269C1 RID: 158145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269C1")]
		[Address(RVA = "0x21ABEB0", Offset = "0x21AAAB0", VA = "0x1821ABEB0")]
		public void TriggerFogDismiss()
		{
		}

		// Token: 0x060269C2 RID: 158146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269C2")]
		[Address(RVA = "0x21ABF30", Offset = "0x21AAB30", VA = "0x1821ABF30")]
		public void TriggerStageNotOpen(StageFogInfo fogInfo)
		{
		}

		// Token: 0x060269C3 RID: 158147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269C3")]
		[Address(RVA = "0x21ABA60", Offset = "0x21AA660", VA = "0x1821ABA60")]
		protected UIItemViewModel GetUnlockItemModel(StageFogOnMapBase.Param param)
		{
			return null;
		}

		// Token: 0x060269C4 RID: 158148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269C4")]
		[Address(RVA = "0x21ABB30", Offset = "0x21AA730", VA = "0x1821ABB30", Slot = "5")]
		protected virtual void OnFogDismiss()
		{
		}

		// Token: 0x060269C5 RID: 158149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269C5")]
		[Address(RVA = "0x21ABB90", Offset = "0x21AA790", VA = "0x1821ABB90", Slot = "6")]
		protected virtual void OnStageNotOpen(StageFogInfo fogInfo)
		{
		}

		// Token: 0x060269C6 RID: 158150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269C6")]
		[Address(RVA = "0x21ABBF0", Offset = "0x21AA7F0", VA = "0x1821ABBF0")]
		protected static void RouteParamStatus(StageFogOnMapBase.ParamStatusRouter router)
		{
		}

		// Token: 0x060269C7 RID: 158151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269C7")]
		[Address(RVA = "0x21ABFC0", Offset = "0x21AABC0", VA = "0x1821ABFC0")]
		protected StageFogOnMapBase()
		{
		}

		// Token: 0x040367A5 RID: 223141
		[Token(Token = "0x40367A5")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action<string> onFogClicked;

		// Token: 0x040367A6 RID: 223142
		[Token(Token = "0x40367A6")]
		[FieldOffset(Offset = "0x20")]
		private UIItemViewModel m_unlockItemModel;

		// Token: 0x040367A7 RID: 223143
		[Token(Token = "0x40367A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TriggerFogDismiss;

		// Token: 0x040367A8 RID: 223144
		[Token(Token = "0x40367A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TriggerStageNotOpen;

		// Token: 0x040367A9 RID: 223145
		[Token(Token = "0x40367A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetUnlockItemModel;

		// Token: 0x040367AA RID: 223146
		[Token(Token = "0x40367AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFogDismiss;

		// Token: 0x040367AB RID: 223147
		[Token(Token = "0x40367AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStageNotOpen;

		// Token: 0x040367AC RID: 223148
		[Token(Token = "0x40367AC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RouteParamStatus;

		// Token: 0x040367AD RID: 223149
		[Token(Token = "0x40367AD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006961 RID: 26977
		[Token(Token = "0x2006961")]
		public struct Param
		{
			// Token: 0x040367AE RID: 223150
			[Token(Token = "0x40367AE")]
			[FieldOffset(Offset = "0x0")]
			public StageFogInfo fogInfo;

			// Token: 0x040367AF RID: 223151
			[Token(Token = "0x40367AF")]
			[FieldOffset(Offset = "0x8")]
			public int unlockItemNum;

			// Token: 0x040367B0 RID: 223152
			[Token(Token = "0x40367B0")]
			[FieldOffset(Offset = "0xC")]
			public bool showUnlockInfo;

			// Token: 0x040367B1 RID: 223153
			[Token(Token = "0x40367B1")]
			[FieldOffset(Offset = "0xD")]
			public bool unlockable;

			// Token: 0x040367B2 RID: 223154
			[Token(Token = "0x40367B2")]
			[FieldOffset(Offset = "0xE")]
			public bool prevFogUnlocked;

			// Token: 0x040367B3 RID: 223155
			[Token(Token = "0x40367B3")]
			[FieldOffset(Offset = "0xF")]
			public bool prevStagePassed;

			// Token: 0x040367B4 RID: 223156
			[Token(Token = "0x40367B4")]
			[FieldOffset(Offset = "0x10")]
			public bool prevStageUnlocked;
		}

		// Token: 0x02006962 RID: 26978
		[Token(Token = "0x2006962")]
		protected struct ParamStatusRouter
		{
			// Token: 0x040367B5 RID: 223157
			[Token(Token = "0x40367B5")]
			[FieldOffset(Offset = "0x0")]
			public StageFogOnMapBase.Param param;

			// Token: 0x040367B6 RID: 223158
			[Token(Token = "0x40367B6")]
			[FieldOffset(Offset = "0x18")]
			public Action<StageFogOnMapBase.Param> onFogUnlockable;

			// Token: 0x040367B7 RID: 223159
			[Token(Token = "0x40367B7")]
			[FieldOffset(Offset = "0x20")]
			public Action<StageFogOnMapBase.Param> onFogUnlockItemNotEnough;

			// Token: 0x040367B8 RID: 223160
			[Token(Token = "0x40367B8")]
			[FieldOffset(Offset = "0x28")]
			public Action<StageFogOnMapBase.Param, StageData> onFogUnlockStageNotPass;
		}
	}
}
