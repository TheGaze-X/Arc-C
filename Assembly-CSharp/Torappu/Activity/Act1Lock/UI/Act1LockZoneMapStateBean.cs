using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x02007897 RID: 30871
	[Token(Token = "0x2007897")]
	public class Act1LockZoneMapStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x17006539 RID: 25913
		// (get) Token: 0x0602B480 RID: 177280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006539")]
		public Act1LockStageViewModel selectedStageModel
		{
			[Token(Token = "0x602B480")]
			[Address(RVA = "0x2719430", Offset = "0x2718030", VA = "0x182719430")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B481 RID: 177281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B481")]
		[Address(RVA = "0x2718E80", Offset = "0x2717A80", VA = "0x182718E80")]
		public void InitData()
		{
		}

		// Token: 0x0602B482 RID: 177282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B482")]
		private void _AddDetailProp<T>() where T : Act1LockDetailModelBase, new()
		{
		}

		// Token: 0x0602B483 RID: 177283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B483")]
		[Address(RVA = "0x2718DA0", Offset = "0x27179A0", VA = "0x182718DA0")]
		public Act1LockStageViewModel FindStageModelByStageId(string stageId)
		{
			return null;
		}

		// Token: 0x0602B484 RID: 177284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B484")]
		[Address(RVA = "0x2719080", Offset = "0x2717C80", VA = "0x182719080")]
		public void RefreshAct1LockZoneMapData()
		{
		}

		// Token: 0x0602B485 RID: 177285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B485")]
		[Address(RVA = "0x2719140", Offset = "0x2717D40", VA = "0x182719140")]
		public void SelectStage(Act1LockStageViewModel stageViewModel)
		{
		}

		// Token: 0x0602B486 RID: 177286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B486")]
		[Address(RVA = "0x2718C30", Offset = "0x2717830", VA = "0x182718C30")]
		public void BindDetailProp(Act1LockDetailViewBase detailView, ActivityInterlockData.InterlockStageType stageType)
		{
		}

		// Token: 0x0602B487 RID: 177287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B487")]
		[Address(RVA = "0x2719340", Offset = "0x2717F40", VA = "0x182719340")]
		public Act1LockZoneMapStateBean()
		{
		}

		// Token: 0x0403E8C1 RID: 256193
		[Token(Token = "0x403E8C1")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string zoneId;

		// Token: 0x0403E8C2 RID: 256194
		[Token(Token = "0x403E8C2")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Act1LockZoneMapViewModel zoneViewModel;

		// Token: 0x0403E8C3 RID: 256195
		[Token(Token = "0x403E8C3")]
		[FieldOffset(Offset = "0x28")]
		public Act1LockZoneMapViewProperty property;

		// Token: 0x0403E8C4 RID: 256196
		[Token(Token = "0x403E8C4")]
		[FieldOffset(Offset = "0x30")]
		public Act1LockDetailAutoBattleProperty autoBattleProperty;

		// Token: 0x0403E8C5 RID: 256197
		[Token(Token = "0x403E8C5")]
		[FieldOffset(Offset = "0x38")]
		public List<Act1LockDetailProperty> detailPropList;

		// Token: 0x0403E8C6 RID: 256198
		[Token(Token = "0x403E8C6")]
		[FieldOffset(Offset = "0x40")]
		private Act1LockStageViewModel m_selectedStageModel;

		// Token: 0x0403E8C7 RID: 256199
		[Token(Token = "0x403E8C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedStageModel;

		// Token: 0x0403E8C8 RID: 256200
		[Token(Token = "0x403E8C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403E8C9 RID: 256201
		[Token(Token = "0x403E8C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddDetailProp;

		// Token: 0x0403E8CA RID: 256202
		[Token(Token = "0x403E8CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FindStageModelByStageId;

		// Token: 0x0403E8CB RID: 256203
		[Token(Token = "0x403E8CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshAct1LockZoneMapData;

		// Token: 0x0403E8CC RID: 256204
		[Token(Token = "0x403E8CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectStage;

		// Token: 0x0403E8CD RID: 256205
		[Token(Token = "0x403E8CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BindDetailProp;

		// Token: 0x0403E8CE RID: 256206
		[Token(Token = "0x403E8CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
