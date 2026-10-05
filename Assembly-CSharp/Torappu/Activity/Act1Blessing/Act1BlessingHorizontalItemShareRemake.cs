using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Blessing
{
	// Token: 0x020078F9 RID: 30969
	[Token(Token = "0x20078F9")]
	public class Act1BlessingHorizontalItemShareRemake : CrossAppShareRemakeModelApplier
	{
		// Token: 0x0602B6CA RID: 177866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6CA")]
		[Address(RVA = "0x2751BF0", Offset = "0x27507F0", VA = "0x182751BF0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602B6CB RID: 177867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6CB")]
		[Address(RVA = "0x2752010", Offset = "0x2750C10", VA = "0x182752010")]
		public Act1BlessingHorizontalItemShareRemake()
		{
		}

		// Token: 0x0403ECC2 RID: 257218
		[Token(Token = "0x403ECC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _charNameText;

		// Token: 0x0403ECC3 RID: 257219
		[Token(Token = "0x403ECC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Cross App Share")]
		private UIAtlasImage _blessingGroupImg;

		// Token: 0x0403ECC4 RID: 257220
		[Token(Token = "0x403ECC4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _charBlessingText;

		// Token: 0x0403ECC5 RID: 257221
		[Token(Token = "0x403ECC5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _charBlessingShadow;

		// Token: 0x0403ECC6 RID: 257222
		[Token(Token = "0x403ECC6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _playerIdText;

		// Token: 0x0403ECC7 RID: 257223
		[Token(Token = "0x403ECC7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _playerNameText;

		// Token: 0x0403ECC8 RID: 257224
		[Token(Token = "0x403ECC8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _playerLvText;

		// Token: 0x0403ECC9 RID: 257225
		[Token(Token = "0x403ECC9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareRemakeDynAssetContent _crossAppShareAvatarContent;

		// Token: 0x0403ECCA RID: 257226
		[Token(Token = "0x403ECCA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareRemakeDynAssetContent _crossAppShareIllustContent;

		// Token: 0x0403ECCB RID: 257227
		[Token(Token = "0x403ECCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0403ECCC RID: 257228
		[Token(Token = "0x403ECCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
