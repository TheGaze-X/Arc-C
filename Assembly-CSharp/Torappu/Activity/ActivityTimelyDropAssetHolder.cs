using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D6A RID: 28010
	[Token(Token = "0x2006D6A")]
	public class ActivityTimelyDropAssetHolder : ActivityAssetHolder
	{
		// Token: 0x06027EA0 RID: 163488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EA0")]
		[Address(RVA = "0x233F050", Offset = "0x233DC50", VA = "0x18233F050", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027EA1 RID: 163489 RVA: 0x000CFFD8 File Offset: 0x000CE1D8
		[Token(Token = "0x6027EA1")]
		[Address(RVA = "0x233F130", Offset = "0x233DD30", VA = "0x18233F130")]
		public bool TryToGetTimelyDropAsset(TimelyDropAssetType assetType, out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06027EA2 RID: 163490 RVA: 0x000CFFF0 File Offset: 0x000CE1F0
		[Token(Token = "0x6027EA2")]
		[Address(RVA = "0x233F8C0", Offset = "0x233E4C0", VA = "0x18233F8C0")]
		private bool _TryToGetZoneSelectExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06027EA3 RID: 163491 RVA: 0x000D0008 File Offset: 0x000CE208
		[Token(Token = "0x6027EA3")]
		[Address(RVA = "0x233F620", Offset = "0x233E220", VA = "0x18233F620")]
		private bool _TryToGetDropPicExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06027EA4 RID: 163492 RVA: 0x000D0020 File Offset: 0x000CE220
		[Token(Token = "0x6027EA4")]
		[Address(RVA = "0x233F4D0", Offset = "0x233E0D0", VA = "0x18233F4D0")]
		private bool _TryToGetDropPicAndApProtectExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06027EA5 RID: 163493 RVA: 0x000D0038 File Offset: 0x000CE238
		[Token(Token = "0x6027EA5")]
		[Address(RVA = "0x233F700", Offset = "0x233E300", VA = "0x18233F700")]
		private bool _TryToGetStagePicExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06027EA6 RID: 163494 RVA: 0x000D0050 File Offset: 0x000CE250
		[Token(Token = "0x6027EA6")]
		[Address(RVA = "0x233F7E0", Offset = "0x233E3E0", VA = "0x18233F7E0")]
		private bool _TryToGetStageTimelyDropStyle(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06027EA7 RID: 163495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EA7")]
		[Address(RVA = "0x233F9A0", Offset = "0x233E5A0", VA = "0x18233F9A0")]
		public ActivityTimelyDropAssetHolder()
		{
		}

		// Token: 0x04038936 RID: 231734
		[Token(Token = "0x4038936")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _zoneSelectExDrop;

		// Token: 0x04038937 RID: 231735
		[Token(Token = "0x4038937")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _dropPicExDrop;

		// Token: 0x04038938 RID: 231736
		[Token(Token = "0x4038938")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _dropPicAndApProtectExDrop;

		// Token: 0x04038939 RID: 231737
		[Token(Token = "0x4038939")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _stagePicExDrop;

		// Token: 0x0403893A RID: 231738
		[Token(Token = "0x403893A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StageTimelyDropStyle _stageTimelyDropStyle;

		// Token: 0x0403893B RID: 231739
		[Token(Token = "0x403893B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x0403893C RID: 231740
		[Token(Token = "0x403893C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryToGetTimelyDropAsset;

		// Token: 0x0403893D RID: 231741
		[Token(Token = "0x403893D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryToGetZoneSelectExDrop;

		// Token: 0x0403893E RID: 231742
		[Token(Token = "0x403893E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryToGetDropPicExDrop;

		// Token: 0x0403893F RID: 231743
		[Token(Token = "0x403893F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryToGetDropPicAndApProtectExDrop;

		// Token: 0x04038940 RID: 231744
		[Token(Token = "0x4038940")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryToGetStagePicExDrop;

		// Token: 0x04038941 RID: 231745
		[Token(Token = "0x4038941")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryToGetStageTimelyDropStyle;

		// Token: 0x04038942 RID: 231746
		[Token(Token = "0x4038942")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
