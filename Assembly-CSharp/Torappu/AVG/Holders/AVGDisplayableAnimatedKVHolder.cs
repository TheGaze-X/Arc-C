using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG.Holders
{
	// Token: 0x02001F95 RID: 8085
	[Token(Token = "0x2001F95")]
	public class AVGDisplayableAnimatedKVHolder : AVGDisplayableHolder, AVGDisplayableHolder.IPositionFeature, AVGDisplayableHolder.IFeature, IHotfixable, AVGDisplayableHolder.IScaleFeature, AVGDisplayableHolder.IEntryFeature
	{
		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x0600C8E9 RID: 51433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017CB")]
		public Transform contentTransform
		{
			[Token(Token = "0x600C8E9")]
			[Address(RVA = "0x348C240", Offset = "0x348AE40", VA = "0x18348C240", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C8EA")]
		[Address(RVA = "0x348BD60", Offset = "0x348A960", VA = "0x18348BD60", Slot = "5")]
		public override GameObject GenerateContent(AVGDisplayableHolder.AVGDisplayParam param)
		{
			return null;
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C8EB")]
		[Address(RVA = "0x348C0E0", Offset = "0x348ACE0", VA = "0x18348C0E0", Slot = "8")]
		public Tween PlayEntry(float from, float to, float duration)
		{
			return null;
		}

		// Token: 0x0600C8EC RID: 51436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8EC")]
		[Address(RVA = "0x348C1E0", Offset = "0x348ADE0", VA = "0x18348C1E0")]
		public AVGDisplayableAnimatedKVHolder()
		{
		}

		// Token: 0x0400CF73 RID: 53107
		[Token(Token = "0x400CF73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x0400CF74 RID: 53108
		[Token(Token = "0x400CF74")]
		[FieldOffset(Offset = "0x38")]
		private AVGAnimatedKV m_instance;

		// Token: 0x0400CF75 RID: 53109
		[Token(Token = "0x400CF75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_contentTransform;

		// Token: 0x0400CF76 RID: 53110
		[Token(Token = "0x400CF76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateContent;

		// Token: 0x0400CF77 RID: 53111
		[Token(Token = "0x400CF77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayEntry;

		// Token: 0x0400CF78 RID: 53112
		[Token(Token = "0x400CF78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
