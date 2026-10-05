using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Act1Blessing
{
	// Token: 0x02006AA3 RID: 27299
	[Token(Token = "0x2006AA3")]
	public class Act1BlessingBlessCollectionShareRemake : CrossAppShareRemakeModelApplier
	{
		// Token: 0x060270CE RID: 159950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270CE")]
		[Address(RVA = "0x2232B00", Offset = "0x2231700", VA = "0x182232B00", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x060270CF RID: 159951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270CF")]
		[Address(RVA = "0x2232EB0", Offset = "0x2231AB0", VA = "0x182232EB0")]
		public Act1BlessingBlessCollectionShareRemake()
		{
		}

		// Token: 0x04037435 RID: 226357
		[Token(Token = "0x4037435")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Cross App Share")]
		private Image _charAvatar1;

		// Token: 0x04037436 RID: 226358
		[Token(Token = "0x4037436")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Cross App Share")]
		private Image _charAvatar2;

		// Token: 0x04037437 RID: 226359
		[Token(Token = "0x4037437")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Cross App Share")]
		private Image _charAvatar3;

		// Token: 0x04037438 RID: 226360
		[Token(Token = "0x4037438")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Cross App Share")]
		private Image _charAvatar4;

		// Token: 0x04037439 RID: 226361
		[Token(Token = "0x4037439")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _playerIdText;

		// Token: 0x0403743A RID: 226362
		[Token(Token = "0x403743A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _playerNameText;

		// Token: 0x0403743B RID: 226363
		[Token(Token = "0x403743B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Cross App Share")]
		private Text _playerLvText;

		// Token: 0x0403743C RID: 226364
		[Token(Token = "0x403743C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Cross App Share")]
		private CrossAppShareRemakeDynAssetContent _avatarContent;

		// Token: 0x0403743D RID: 226365
		[Token(Token = "0x403743D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0403743E RID: 226366
		[Token(Token = "0x403743E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
