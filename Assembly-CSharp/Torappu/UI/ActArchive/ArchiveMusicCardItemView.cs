using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BAC RID: 27564
	[Token(Token = "0x2006BAC")]
	public class ArchiveMusicCardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060275D0 RID: 161232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275D0")]
		[Address(RVA = "0x2291690", Offset = "0x2290290", VA = "0x182291690")]
		public void Render(MusicItemModel model)
		{
		}

		// Token: 0x060275D1 RID: 161233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275D1")]
		[Address(RVA = "0x2291870", Offset = "0x2290470", VA = "0x182291870")]
		public void ResetPosition(bool isDown = true)
		{
		}

		// Token: 0x060275D2 RID: 161234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275D2")]
		[Address(RVA = "0x2291490", Offset = "0x2290090", VA = "0x182291490")]
		public Sequence GetAnimSequence(bool isShowing)
		{
			return null;
		}

		// Token: 0x060275D3 RID: 161235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275D3")]
		[Address(RVA = "0x2291A20", Offset = "0x2290620", VA = "0x182291A20")]
		public ArchiveMusicCardItemView()
		{
		}

		// Token: 0x04037C42 RID: 228418
		[Token(Token = "0x4037C42")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Title")]
		private Text _title;

		// Token: 0x04037C43 RID: 228419
		[Token(Token = "0x4037C43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Title")]
		private RectTransform _titleTransform;

		// Token: 0x04037C44 RID: 228420
		[Token(Token = "0x4037C44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Title")]
		private float _titleAnimDeltaY;

		// Token: 0x04037C45 RID: 228421
		[Token(Token = "0x4037C45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Count")]
		private Text _count;

		// Token: 0x04037C46 RID: 228422
		[Token(Token = "0x4037C46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Count")]
		private RectTransform _countTransform;

		// Token: 0x04037C47 RID: 228423
		[Token(Token = "0x4037C47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Count")]
		private float _countAnimDeltaY;

		// Token: 0x04037C48 RID: 228424
		[Token(Token = "0x4037C48")]
		[FieldOffset(Offset = "0x48")]
		private MusicItemModel m_cachedModel;

		// Token: 0x04037C49 RID: 228425
		[Token(Token = "0x4037C49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037C4A RID: 228426
		[Token(Token = "0x4037C4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetPosition;

		// Token: 0x04037C4B RID: 228427
		[Token(Token = "0x4037C4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAnimSequence;

		// Token: 0x04037C4C RID: 228428
		[Token(Token = "0x4037C4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
