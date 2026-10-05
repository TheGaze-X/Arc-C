using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.DynamicSprite
{
	// Token: 0x02005A51 RID: 23121
	[Token(Token = "0x2005A51")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class DynamicSpriteControllerOnPage : MonoBehaviour, IOnPrefabUpdated
	{
		// Token: 0x06021A7C RID: 137852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A7C")]
		[Address(RVA = "0x1C1A590", Offset = "0x1C19190", VA = "0x181C1A590")]
		private void _OnPageReady()
		{
		}

		// Token: 0x06021A7D RID: 137853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A7D")]
		[Address(RVA = "0x1C1A470", Offset = "0x1C19070", VA = "0x181C1A470")]
		private void _OnPageNotFound()
		{
		}

		// Token: 0x06021A7E RID: 137854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A7E")]
		[Address(RVA = "0x1C1A290", Offset = "0x1C18E90", VA = "0x181C1A290", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06021A7F RID: 137855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A7F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnPrefabUpdated()
		{
		}

		// Token: 0x06021A80 RID: 137856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A80")]
		[Address(RVA = "0x1C1A6D0", Offset = "0x1C192D0", VA = "0x181C1A6D0")]
		public DynamicSpriteControllerOnPage()
		{
		}

		// Token: 0x0402E051 RID: 188497
		[Token(Token = "0x402E051")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private DynamicSpriteLoader[] _loaders;

		// Token: 0x0402E052 RID: 188498
		[Token(Token = "0x402E052")]
		[FieldOffset(Offset = "0x20")]
		private UIPageListener m_pageListener;

		// Token: 0x02005A52 RID: 23122
		[Token(Token = "0x2005A52")]
		private abstract class BaseSpriteLoader : ISpriteAssetLoader
		{
			// Token: 0x06021A81 RID: 137857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A81")]
			[Address(RVA = "0x1C16A30", Offset = "0x1C15630", VA = "0x181C16A30", Slot = "4")]
			public void LoadAsync(DynamicSpriteLoader.BakeInfo bakeInfo, Action<Sprite> callback)
			{
			}

			// Token: 0x06021A82 RID: 137858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A82")]
			[Address(RVA = "0x1C16C70", Offset = "0x1C15870", VA = "0x181C16C70")]
			private static void _ErrorFallback(Action<Sprite> callback, string error)
			{
			}

			// Token: 0x06021A83 RID: 137859
			[Token(Token = "0x6021A83")]
			protected abstract DynamicSpriteHolder LoadSpriteHolder(string holderResPath);

			// Token: 0x06021A84 RID: 137860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A84")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected BaseSpriteLoader()
			{
			}
		}

		// Token: 0x02005A53 RID: 23123
		[Token(Token = "0x2005A53")]
		private class PageSpriteLoader : DynamicSpriteControllerOnPage.BaseSpriteLoader
		{
			// Token: 0x06021A85 RID: 137861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A85")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public PageSpriteLoader(UIPage page)
			{
			}

			// Token: 0x06021A86 RID: 137862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A86")]
			[Address(RVA = "0x1C1B180", Offset = "0x1C19D80", VA = "0x181C1B180", Slot = "5")]
			protected override DynamicSpriteHolder LoadSpriteHolder(string holderResPath)
			{
				return null;
			}

			// Token: 0x0402E053 RID: 188499
			[Token(Token = "0x402E053")]
			[FieldOffset(Offset = "0x10")]
			private UIPage m_page;
		}

		// Token: 0x02005A54 RID: 23124
		[Token(Token = "0x2005A54")]
		private class UISceneSpriteLoader : DynamicSpriteControllerOnPage.BaseSpriteLoader
		{
			// Token: 0x06021A87 RID: 137863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A87")]
			[Address(RVA = "0x1C2E360", Offset = "0x1C2CF60", VA = "0x181C2E360", Slot = "5")]
			protected override DynamicSpriteHolder LoadSpriteHolder(string holderResPath)
			{
				return null;
			}

			// Token: 0x06021A88 RID: 137864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A88")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UISceneSpriteLoader()
			{
			}
		}
	}
}
