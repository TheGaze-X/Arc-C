using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E4A RID: 15946
	[Token(Token = "0x2003E4A")]
	public class SpecialOperatorNodePointModel : SpecialOperatorDiagramPointModel
	{
		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x06018C6E RID: 101486 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018C6F RID: 101487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B03")]
		public SpecialOperatorBoardNodeBase nodeModel
		{
			[Token(Token = "0x6018C6E")]
			[Address(RVA = "0x117C030", Offset = "0x117AC30", VA = "0x18117C030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018C6F")]
			[Address(RVA = "0x117C540", Offset = "0x117B140", VA = "0x18117C540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x06018C70 RID: 101488 RVA: 0x0009BB20 File Offset: 0x00099D20
		[Token(Token = "0x17003B04")]
		public override SpecialOperatorPointViewType pointViewType
		{
			[Token(Token = "0x6018C70")]
			[Address(RVA = "0x117C090", Offset = "0x117AC90", VA = "0x18117C090", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x06018C71 RID: 101489 RVA: 0x0009BB38 File Offset: 0x00099D38
		[Token(Token = "0x17003B05")]
		public override SpecialOperatorSelectAnchorType selectAnchorType
		{
			[Token(Token = "0x6018C71")]
			[Address(RVA = "0x117C470", Offset = "0x117B070", VA = "0x18117C470", Slot = "7")]
			get
			{
				return SpecialOperatorSelectAnchorType.OFFSET;
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x06018C72 RID: 101490 RVA: 0x0009BB50 File Offset: 0x00099D50
		[Token(Token = "0x17003B06")]
		public override Vector2 selectAnchorPos
		{
			[Token(Token = "0x6018C72")]
			[Address(RVA = "0x117C220", Offset = "0x117AE20", VA = "0x18117C220", Slot = "8")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06018C73 RID: 101491 RVA: 0x0009BB68 File Offset: 0x00099D68
		[Token(Token = "0x6018C73")]
		[Address(RVA = "0x117B9C0", Offset = "0x117A5C0", VA = "0x18117B9C0", Slot = "10")]
		public override bool CalcUnlockStatus(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018C74 RID: 101492 RVA: 0x0009BB80 File Offset: 0x00099D80
		[Token(Token = "0x6018C74")]
		[Address(RVA = "0x117BCD0", Offset = "0x117A8D0", VA = "0x18117BCD0", Slot = "9")]
		public override bool TryGetNodeModel(string nodeId, out SpecialOperatorBoardNodeBase retModel)
		{
			return default(bool);
		}

		// Token: 0x06018C75 RID: 101493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C75")]
		[Address(RVA = "0x117BAB0", Offset = "0x117A6B0", VA = "0x18117BAB0", Slot = "4")]
		protected override void OnLoadData(SpecialOperatorDiagramData diagramData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018C76 RID: 101494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C76")]
		[Address(RVA = "0x117BBF0", Offset = "0x117A7F0", VA = "0x18117BBF0", Slot = "5")]
		protected override void OnRefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018C77 RID: 101495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C77")]
		[Address(RVA = "0x117BF90", Offset = "0x117AB90", VA = "0x18117BF90")]
		public SpecialOperatorNodePointModel()
		{
		}

		// Token: 0x06018C78 RID: 101496 RVA: 0x0009BB98 File Offset: 0x00099D98
		[Token(Token = "0x6018C78")]
		[Address(RVA = "0x117A4B0", Offset = "0x11790B0", VA = "0x18117A4B0")]
		private SpecialOperatorSelectAnchorType <>xLuaBaseProxy_get_selectAnchorType()
		{
			return SpecialOperatorSelectAnchorType.OFFSET;
		}

		// Token: 0x06018C79 RID: 101497 RVA: 0x0009BBB0 File Offset: 0x00099DB0
		[Token(Token = "0x6018C79")]
		[Address(RVA = "0x117BEB0", Offset = "0x117AAB0", VA = "0x18117BEB0")]
		private Vector2 <>xLuaBaseProxy_get_selectAnchorPos()
		{
			return default(Vector2);
		}

		// Token: 0x06018C7A RID: 101498 RVA: 0x0009BBC8 File Offset: 0x00099DC8
		[Token(Token = "0x6018C7A")]
		[Address(RVA = "0x1179ED0", Offset = "0x1178AD0", VA = "0x181179ED0")]
		private bool <>xLuaBaseProxy_CalcUnlockStatus(string P0)
		{
			return default(bool);
		}

		// Token: 0x06018C7B RID: 101499 RVA: 0x0009BBE0 File Offset: 0x00099DE0
		[Token(Token = "0x6018C7B")]
		[Address(RVA = "0x117A210", Offset = "0x1178E10", VA = "0x18117A210")]
		private bool <>xLuaBaseProxy_TryGetNodeModel(string P0, out SpecialOperatorBoardNodeBase P1)
		{
			return default(bool);
		}

		// Token: 0x06018C7C RID: 101500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C7C")]
		[Address(RVA = "0x117A120", Offset = "0x1178D20", VA = "0x18117A120")]
		private void <>xLuaBaseProxy_OnRefreshData(PlayerCharacter P0)
		{
		}

		// Token: 0x0401E740 RID: 124736
		[Token(Token = "0x401E740")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeModel;

		// Token: 0x0401E741 RID: 124737
		[Token(Token = "0x401E741")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_nodeModel;

		// Token: 0x0401E742 RID: 124738
		[Token(Token = "0x401E742")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pointViewType;

		// Token: 0x0401E743 RID: 124739
		[Token(Token = "0x401E743")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectAnchorType;

		// Token: 0x0401E744 RID: 124740
		[Token(Token = "0x401E744")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectAnchorPos;

		// Token: 0x0401E745 RID: 124741
		[Token(Token = "0x401E745")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalcUnlockStatus;

		// Token: 0x0401E746 RID: 124742
		[Token(Token = "0x401E746")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryGetNodeModel;

		// Token: 0x0401E747 RID: 124743
		[Token(Token = "0x401E747")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLoadData;

		// Token: 0x0401E748 RID: 124744
		[Token(Token = "0x401E748")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x0401E749 RID: 124745
		[Token(Token = "0x401E749")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
