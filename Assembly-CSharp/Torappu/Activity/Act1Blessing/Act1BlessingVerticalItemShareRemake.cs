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
	// Token: 0x020078FC RID: 30972
	[Token(Token = "0x20078FC")]
	public class Act1BlessingVerticalItemShareRemake : CrossAppShareRemakeModelApplier
	{
		// Token: 0x0602B6E2 RID: 177890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6E2")]
		[Address(RVA = "0x2752890", Offset = "0x2751490", VA = "0x182752890", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602B6E3 RID: 177891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6E3")]
		[Address(RVA = "0x2752AF0", Offset = "0x27516F0", VA = "0x182752AF0")]
		public Act1BlessingVerticalItemShareRemake()
		{
		}

		// Token: 0x0403ECF5 RID: 257269
		[Token(Token = "0x403ECF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _charNameText;

		// Token: 0x0403ECF6 RID: 257270
		[Token(Token = "0x403ECF6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Cross App Share")]
		private UIAtlasImage _blessingGroupImg;

		// Token: 0x0403ECF7 RID: 257271
		[Token(Token = "0x403ECF7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _charNameShadow;

		// Token: 0x0403ECF8 RID: 257272
		[Token(Token = "0x403ECF8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareRemakeDynAssetContent _crossAppShareIllustContent;

		// Token: 0x0403ECF9 RID: 257273
		[Token(Token = "0x403ECF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0403ECFA RID: 257274
		[Token(Token = "0x403ECFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
