using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building
{
	// Token: 0x0200180B RID: 6155
	[Token(Token = "0x200180B")]
	public class BuildingAVGAdapter : ExecutorComponent
	{
		// Token: 0x06009BC9 RID: 39881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BC9")]
		[Address(RVA = "0x314ED20", Offset = "0x314D920", VA = "0x18314ED20", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCA")]
		[Address(RVA = "0x314ECC0", Offset = "0x314D8C0", VA = "0x18314ECC0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCB")]
		[Address(RVA = "0x3150090", Offset = "0x314EC90", VA = "0x183150090")]
		private void _OnStoryBegin(object arg)
		{
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCC")]
		[Address(RVA = "0x3150170", Offset = "0x314ED70", VA = "0x183150170")]
		private void _OnStoryEnd(object arg)
		{
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCD")]
		[Address(RVA = "0x314F430", Offset = "0x314E030", VA = "0x18314F430")]
		private void _BlockBuildingModeRaycast(bool isBlock)
		{
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x0003CAF8 File Offset: 0x0003ACF8
		[Token(Token = "0x6009BCE")]
		[Address(RVA = "0x314FE40", Offset = "0x314EA40", VA = "0x18314FE40")]
		private bool _ExecutePrivateReturn(Command command)
		{
			return default(bool);
		}

		// Token: 0x06009BCF RID: 39887 RVA: 0x0003CB10 File Offset: 0x0003AD10
		[Token(Token = "0x6009BCF")]
		[Address(RVA = "0x314FAF0", Offset = "0x314E6F0", VA = "0x18314FAF0")]
		private bool _ExecuteFocusPrivateChar(Command command)
		{
			return default(bool);
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x0003CB28 File Offset: 0x0003AD28
		[Token(Token = "0x6009BD0")]
		[Address(RVA = "0x314F660", Offset = "0x314E260", VA = "0x18314F660")]
		private bool _ExecuteFocusBRoom(Command command)
		{
			return default(bool);
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x0003CB40 File Offset: 0x0003AD40
		[Token(Token = "0x6009BD1")]
		[Address(RVA = "0x314F4D0", Offset = "0x314E0D0", VA = "0x18314F4D0")]
		private bool _ExecuteBlockRaycaster(Command command)
		{
			return default(bool);
		}

		// Token: 0x06009BD2 RID: 39890 RVA: 0x0003CB58 File Offset: 0x0003AD58
		[Token(Token = "0x6009BD2")]
		[Address(RVA = "0x314F580", Offset = "0x314E180", VA = "0x18314F580")]
		private bool _ExecuteEnsureOperationMode(Command command)
		{
			return default(bool);
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD3")]
		[Address(RVA = "0x314F230", Offset = "0x314DE30", VA = "0x18314F230")]
		private void Start()
		{
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD4")]
		[Address(RVA = "0x314F080", Offset = "0x314DC80", VA = "0x18314F080")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD5")]
		[Address(RVA = "0x31501F0", Offset = "0x314EDF0", VA = "0x1831501F0")]
		public BuildingAVGAdapter()
		{
		}

		// Token: 0x0400927D RID: 37501
		[Token(Token = "0x400927D")]
		[FieldOffset(Offset = "0x50")]
		private Button m_bRoomTutorialBtn;

		// Token: 0x0400927E RID: 37502
		[Token(Token = "0x400927E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400927F RID: 37503
		[Token(Token = "0x400927F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x04009280 RID: 37504
		[Token(Token = "0x4009280")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnStoryBegin;

		// Token: 0x04009281 RID: 37505
		[Token(Token = "0x4009281")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStoryEnd;

		// Token: 0x04009282 RID: 37506
		[Token(Token = "0x4009282")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__BlockBuildingModeRaycast;

		// Token: 0x04009283 RID: 37507
		[Token(Token = "0x4009283")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecutePrivateReturn;

		// Token: 0x04009284 RID: 37508
		[Token(Token = "0x4009284")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteFocusPrivateChar;

		// Token: 0x04009285 RID: 37509
		[Token(Token = "0x4009285")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteFocusBRoom;

		// Token: 0x04009286 RID: 37510
		[Token(Token = "0x4009286")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteBlockRaycaster;

		// Token: 0x04009287 RID: 37511
		[Token(Token = "0x4009287")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExecuteEnsureOperationMode;

		// Token: 0x04009288 RID: 37512
		[Token(Token = "0x4009288")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04009289 RID: 37513
		[Token(Token = "0x4009289")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400928A RID: 37514
		[Token(Token = "0x400928A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
