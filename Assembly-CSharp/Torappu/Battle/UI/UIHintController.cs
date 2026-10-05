using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x020032EB RID: 13035
	[Token(Token = "0x20032EB")]
	[RequireComponent(typeof(RectTransform))]
	public class UIHintController : MonoBehaviour
	{
		// Token: 0x06014B68 RID: 84840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B68")]
		[Address(RVA = "0xD2DF70", Offset = "0xD2CB70", VA = "0x180D2DF70")]
		private void Awake()
		{
		}

		// Token: 0x06014B69 RID: 84841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B69")]
		[Address(RVA = "0xD2E280", Offset = "0xD2CE80", VA = "0x180D2E280")]
		public void Show(string text, UIHintController.BannerStyle style)
		{
		}

		// Token: 0x06014B6A RID: 84842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B6A")]
		[Address(RVA = "0xD2E3E0", Offset = "0xD2CFE0", VA = "0x180D2E3E0")]
		private void Update()
		{
		}

		// Token: 0x06014B6B RID: 84843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B6B")]
		[Address(RVA = "0xD2E410", Offset = "0xD2D010", VA = "0x180D2E410")]
		public UIHintController()
		{
		}

		// Token: 0x040189BE RID: 100798
		[Token(Token = "0x40189BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIHintBanner> _banners;

		// Token: 0x040189BF RID: 100799
		[Token(Token = "0x40189BF")]
		[FieldOffset(Offset = "0x20")]
		[Inspect]
		private int m_currentBannerIndex;

		// Token: 0x040189C0 RID: 100800
		[Token(Token = "0x40189C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Collection(typeof(UIHintController.BannerStyle), Sortable = false)]
		private Sprite[] _bannerBackgroundImage;

		// Token: 0x040189C1 RID: 100801
		[Token(Token = "0x40189C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Scroll Settings")]
		private bool _isDownward;

		// Token: 0x040189C2 RID: 100802
		[Token(Token = "0x40189C2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Group("Scroll Settings")]
		private float _scrollSpeed;

		// Token: 0x040189C3 RID: 100803
		[Token(Token = "0x40189C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Scroll Settings")]
		private float _gapHeight;

		// Token: 0x040189C4 RID: 100804
		[Token(Token = "0x40189C4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Group("Scroll Settings")]
		private float _midLine;

		// Token: 0x040189C5 RID: 100805
		[Token(Token = "0x40189C5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Scroll Settings")]
		private float _fadeInDuration;

		// Token: 0x040189C6 RID: 100806
		[Token(Token = "0x40189C6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Scroll Settings")]
		private float _fadeOutDuration;

		// Token: 0x040189C7 RID: 100807
		[Token(Token = "0x40189C7")]
		[FieldOffset(Offset = "0x48")]
		private UIHintController.ScrollController m_scrollController;

		// Token: 0x020032EC RID: 13036
		[Token(Token = "0x20032EC")]
		public enum BannerStyle
		{
			// Token: 0x040189C9 RID: 100809
			[Token(Token = "0x40189C9")]
			DEFAULT,
			// Token: 0x040189CA RID: 100810
			[Token(Token = "0x40189CA")]
			ERROR
		}

		// Token: 0x020032ED RID: 13037
		[Token(Token = "0x20032ED")]
		private class ScrollController
		{
			// Token: 0x17003109 RID: 12553
			// (get) Token: 0x06014B6C RID: 84844 RVA: 0x00088158 File Offset: 0x00086358
			[Token(Token = "0x17003109")]
			[Inspect]
			private int entityCount
			{
				[Token(Token = "0x6014B6C")]
				[Address(RVA = "0xD1B610", Offset = "0xD1A210", VA = "0x180D1B610")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700310A RID: 12554
			// (get) Token: 0x06014B6D RID: 84845 RVA: 0x00088170 File Offset: 0x00086370
			[Token(Token = "0x1700310A")]
			[Inspect]
			private float fadeThreshold
			{
				[Token(Token = "0x6014B6D")]
				[Address(RVA = "0x50EBC0", Offset = "0x50D7C0", VA = "0x18050EBC0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06014B6E RID: 84846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B6E")]
			[Address(RVA = "0xD1B590", Offset = "0xD1A190", VA = "0x180D1B590")]
			public ScrollController(float gap, float midLine, int maxDisplay, List<RectTransform> transformList, bool isDownward = true)
			{
			}

			// Token: 0x06014B6F RID: 84847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B6F")]
			[Address(RVA = "0xD1AFB0", Offset = "0xD19BB0", VA = "0x180D1AFB0")]
			public void Reset(int displayCount = 0)
			{
			}

			// Token: 0x06014B70 RID: 84848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B70")]
			[Address(RVA = "0x50E790", Offset = "0x50D390", VA = "0x18050E790")]
			public void Scroll(float speed, float targetDelta)
			{
			}

			// Token: 0x06014B71 RID: 84849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B71")]
			[Address(RVA = "0x50E720", Offset = "0x50D320", VA = "0x18050E720")]
			public void Scroll(float speed, int steps)
			{
			}

			// Token: 0x06014B72 RID: 84850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014B72")]
			[Address(RVA = "0xD1B240", Offset = "0xD19E40", VA = "0x180D1B240")]
			public void Update(float deltaTime)
			{
			}

			// Token: 0x040189CB RID: 100811
			[Token(Token = "0x40189CB")]
			[FieldOffset(Offset = "0x10")]
			public float gap;

			// Token: 0x040189CC RID: 100812
			[Token(Token = "0x40189CC")]
			[FieldOffset(Offset = "0x14")]
			public float midLine;

			// Token: 0x040189CD RID: 100813
			[Token(Token = "0x40189CD")]
			[FieldOffset(Offset = "0x18")]
			public int maxDisplay;

			// Token: 0x040189CE RID: 100814
			[Token(Token = "0x40189CE")]
			[FieldOffset(Offset = "0x1C")]
			public bool isDownward;

			// Token: 0x040189CF RID: 100815
			[Token(Token = "0x40189CF")]
			[FieldOffset(Offset = "0x20")]
			public List<RectTransform> transformList;

			// Token: 0x040189D0 RID: 100816
			[Token(Token = "0x40189D0")]
			[FieldOffset(Offset = "0x28")]
			public float speed;

			// Token: 0x040189D1 RID: 100817
			[Token(Token = "0x40189D1")]
			[FieldOffset(Offset = "0x2C")]
			public float targetDelta;

			// Token: 0x040189D2 RID: 100818
			[Token(Token = "0x40189D2")]
			[FieldOffset(Offset = "0x30")]
			public bool targetDeltaFinished;
		}
	}
}
