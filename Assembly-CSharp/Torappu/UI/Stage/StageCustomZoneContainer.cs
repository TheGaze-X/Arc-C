using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200695A RID: 26970
	[Token(Token = "0x200695A")]
	public abstract class StageCustomZoneContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x060269A7 RID: 158119
		[Token(Token = "0x60269A7")]
		public abstract void Init(StageCustomZoneContainer.Param initParam, StageCustomZoneContainerHolder holder);

		// Token: 0x060269A8 RID: 158120
		[Token(Token = "0x60269A8")]
		public abstract void Render(ZoneViewModel model);

		// Token: 0x060269A9 RID: 158121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269A9")]
		[Address(RVA = "0x21AB940", Offset = "0x21AA540", VA = "0x1821AB940")]
		protected StageCustomZoneContainer()
		{
		}

		// Token: 0x0403677A RID: 223098
		[Token(Token = "0x403677A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200695B RID: 26971
		[Token(Token = "0x200695B")]
		public struct Param
		{
			// Token: 0x0403677B RID: 223099
			[Token(Token = "0x403677B")]
			[FieldOffset(Offset = "0x0")]
			public Action<string> onMapNotFound;

			// Token: 0x0403677C RID: 223100
			[Token(Token = "0x403677C")]
			[FieldOffset(Offset = "0x8")]
			public Action<string> onMapLoadFinish;

			// Token: 0x0403677D RID: 223101
			[Token(Token = "0x403677D")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> onStageSelect;

			// Token: 0x0403677E RID: 223102
			[Token(Token = "0x403677E")]
			[FieldOffset(Offset = "0x18")]
			public Action<string> onStageFogUnlock;

			// Token: 0x0403677F RID: 223103
			[Token(Token = "0x403677F")]
			[FieldOffset(Offset = "0x20")]
			public Action<string> onSpecialStageReward;

			// Token: 0x04036780 RID: 223104
			[Token(Token = "0x4036780")]
			[FieldOffset(Offset = "0x28")]
			public Action<StageDiffGroup> onSelectDiffAction;

			// Token: 0x04036781 RID: 223105
			[Token(Token = "0x4036781")]
			[FieldOffset(Offset = "0x30")]
			public Action onDiffSelectDetail;

			// Token: 0x04036782 RID: 223106
			[Token(Token = "0x4036782")]
			[FieldOffset(Offset = "0x38")]
			public Action onAddedReceiveCacheEvent;

			// Token: 0x04036783 RID: 223107
			[Token(Token = "0x4036783")]
			[FieldOffset(Offset = "0x40")]
			public Action onClosePreview;
		}
	}
}
