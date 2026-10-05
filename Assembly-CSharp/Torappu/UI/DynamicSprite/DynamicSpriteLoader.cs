using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DynamicSprite
{
	// Token: 0x02005A57 RID: 23127
	[Token(Token = "0x2005A57")]
	[RequireComponent(typeof(Image))]
	public class DynamicSpriteLoader : MonoBehaviour, IOnPrefabUpdated
	{
		// Token: 0x06021A8C RID: 137868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A8C")]
		[Address(RVA = "0x1C1AAA0", Offset = "0x1C196A0", VA = "0x181C1AAA0", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06021A8D RID: 137869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A8D")]
		[Address(RVA = "0x1B023D0", Offset = "0x1B00FD0", VA = "0x181B023D0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06021A8E RID: 137870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A8E")]
		[Address(RVA = "0x1C1AA70", Offset = "0x1C19670", VA = "0x181C1AA70")]
		public void NotifyLoaderReady(ISpriteAssetLoader loader)
		{
		}

		// Token: 0x06021A8F RID: 137871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A8F")]
		[Address(RVA = "0x1C1AB20", Offset = "0x1C19720", VA = "0x181C1AB20")]
		private void _LoadSpriteIfReady()
		{
		}

		// Token: 0x06021A90 RID: 137872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A90")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnPrefabUpdated()
		{
		}

		// Token: 0x06021A91 RID: 137873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A91")]
		[Address(RVA = "0x1C1AC80", Offset = "0x1C19880", VA = "0x181C1AC80")]
		public DynamicSpriteLoader()
		{
		}

		// Token: 0x0402E059 RID: 188505
		[Token(Token = "0x402E059")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private DynamicSpriteLoader.BakeInfo _bakeInfo;

		// Token: 0x0402E05A RID: 188506
		[Token(Token = "0x402E05A")]
		[FieldOffset(Offset = "0x28")]
		private ISpriteAssetLoader m_assetLoader;

		// Token: 0x0402E05B RID: 188507
		[Token(Token = "0x402E05B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isVisible;

		// Token: 0x0402E05C RID: 188508
		[Token(Token = "0x402E05C")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isLoading;

		// Token: 0x0402E05D RID: 188509
		[Token(Token = "0x402E05D")]
		[FieldOffset(Offset = "0x32")]
		private bool m_isLoaded;

		// Token: 0x02005A58 RID: 23128
		[Token(Token = "0x2005A58")]
		[Serializable]
		public struct BakeInfo
		{
			// Token: 0x06021A93 RID: 137875 RVA: 0x000BB0C8 File Offset: 0x000B92C8
			[Token(Token = "0x6021A93")]
			[Address(RVA = "0x12E7370", Offset = "0x12E5F70", VA = "0x1812E7370")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0402E05E RID: 188510
			[Token(Token = "0x402E05E")]
			[FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public static readonly DynamicSpriteLoader.BakeInfo EMPTY;

			// Token: 0x0402E05F RID: 188511
			[Token(Token = "0x402E05F")]
			[FieldOffset(Offset = "0x0")]
			public string id;

			// Token: 0x0402E060 RID: 188512
			[Token(Token = "0x402E060")]
			[FieldOffset(Offset = "0x8")]
			public string holderName;
		}
	}
}
