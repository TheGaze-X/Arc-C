using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DC6 RID: 19910
	[Token(Token = "0x2004DC6")]
	public class NameCardV2ShareAvatarSimpleRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DC46 RID: 121926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC46")]
		[Address(RVA = "0x175FAF0", Offset = "0x175E6F0", VA = "0x18175FAF0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC47 RID: 121927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC47")]
		[Address(RVA = "0x175FDA0", Offset = "0x175E9A0", VA = "0x18175FDA0")]
		public NameCardV2ShareAvatarSimpleRemakeLayoutElement()
		{
		}

		// Token: 0x04027647 RID: 161351
		[Token(Token = "0x4027647")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x04027648 RID: 161352
		[Token(Token = "0x4027648")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x04027649 RID: 161353
		[Token(Token = "0x4027649")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x0402764A RID: 161354
		[Token(Token = "0x402764A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CrossAppShareRemakeDynAssetContent _crossAppShareAvatarContent;

		// Token: 0x0402764B RID: 161355
		[Token(Token = "0x402764B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _uidObject;

		// Token: 0x0402764C RID: 161356
		[Token(Token = "0x402764C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0402764D RID: 161357
		[Token(Token = "0x402764D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
