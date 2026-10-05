using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006005 RID: 24581
	[Token(Token = "0x2006005")]
	public class CGGalleryCollectionLineItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170053F1 RID: 21489
		// (get) Token: 0x0602387F RID: 145535 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023880 RID: 145536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053F1")]
		public Action<int> focusAction
		{
			[Token(Token = "0x602387F")]
			[Address(RVA = "0x1E2BEE0", Offset = "0x1E2AAE0", VA = "0x181E2BEE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023880")]
			[Address(RVA = "0x1E2BFB0", Offset = "0x1E2ABB0", VA = "0x181E2BFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170053F2 RID: 21490
		// (get) Token: 0x06023881 RID: 145537 RVA: 0x000C1320 File Offset: 0x000BF520
		[Token(Token = "0x170053F2")]
		public float focusDuration
		{
			[Token(Token = "0x6023881")]
			[Address(RVA = "0x1E2BF40", Offset = "0x1E2AB40", VA = "0x181E2BF40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06023882 RID: 145538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023882")]
		[Address(RVA = "0x1E2BBB0", Offset = "0x1E2A7B0", VA = "0x181E2BBB0")]
		public void OnClickEvent()
		{
		}

		// Token: 0x06023883 RID: 145539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023883")]
		[Address(RVA = "0x1E2BC80", Offset = "0x1E2A880", VA = "0x181E2BC80")]
		public void Render(CGGalleryCollectionDisplayGroupView.GroupIndexModel model)
		{
		}

		// Token: 0x06023884 RID: 145540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023884")]
		[Address(RVA = "0x1E2BA70", Offset = "0x1E2A670", VA = "0x181E2BA70")]
		public void ApplyDistance(float signedDistance)
		{
		}

		// Token: 0x06023885 RID: 145541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023885")]
		[Address(RVA = "0x1E2BDA0", Offset = "0x1E2A9A0", VA = "0x181E2BDA0")]
		private void _InitAnimationLengthIfNot()
		{
		}

		// Token: 0x06023886 RID: 145542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023886")]
		[Address(RVA = "0x1E2BE70", Offset = "0x1E2AA70", VA = "0x181E2BE70")]
		public CGGalleryCollectionLineItemView()
		{
		}

		// Token: 0x0403129A RID: 201370
		[Token(Token = "0x403129A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIDynImage _titleImage;

		// Token: 0x0403129B RID: 201371
		[Token(Token = "0x403129B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _positionAnimation;

		// Token: 0x0403129C RID: 201372
		[Token(Token = "0x403129C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _positionDistance;

		// Token: 0x0403129D RID: 201373
		[Token(Token = "0x403129D")]
		[FieldOffset(Offset = "0x34")]
		private float m_positionAnimationLength;

		// Token: 0x0403129E RID: 201374
		[Token(Token = "0x403129E")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_finder;

		// Token: 0x0403129F RID: 201375
		[Token(Token = "0x403129F")]
		[FieldOffset(Offset = "0x48")]
		private CGGalleryCollectionDisplayGroupView.GroupIndexModel m_cachedGroupIndex;

		// Token: 0x040312A0 RID: 201376
		[Token(Token = "0x40312A0")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedIconId;

		// Token: 0x040312A2 RID: 201378
		[Token(Token = "0x40312A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusAction;

		// Token: 0x040312A3 RID: 201379
		[Token(Token = "0x40312A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusAction;

		// Token: 0x040312A4 RID: 201380
		[Token(Token = "0x40312A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_focusDuration;

		// Token: 0x040312A5 RID: 201381
		[Token(Token = "0x40312A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x040312A6 RID: 201382
		[Token(Token = "0x40312A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040312A7 RID: 201383
		[Token(Token = "0x40312A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyDistance;

		// Token: 0x040312A8 RID: 201384
		[Token(Token = "0x40312A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitAnimationLengthIfNot;

		// Token: 0x040312A9 RID: 201385
		[Token(Token = "0x40312A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
