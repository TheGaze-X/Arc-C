using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034A3 RID: 13475
	[Token(Token = "0x20034A3")]
	[CreateAssetMenu(menuName = "Torappu/Atlas/UIAtlasObject")]
	public class UIAtlasObject : ScriptableObject, IHotfixable
	{
		// Token: 0x060157C4 RID: 88004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157C4")]
		[Address(RVA = "0xE07A20", Offset = "0xE06620", VA = "0x180E07A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060157C5 RID: 88005 RVA: 0x0008C310 File Offset: 0x0008A510
		[Token(Token = "0x60157C5")]
		[Address(RVA = "0xE07720", Offset = "0xE06320", VA = "0x180E07720")]
		public SpriteRenderData GUID2Sprite(string guid)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060157C6 RID: 88006 RVA: 0x0008C328 File Offset: 0x0008A528
		[Token(Token = "0x60157C6")]
		[Address(RVA = "0xE078A0", Offset = "0xE064A0", VA = "0x180E078A0")]
		public SpriteRenderData GetSpriteByName(string name)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060157C7 RID: 88007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157C7")]
		[Address(RVA = "0xE07C60", Offset = "0xE06860", VA = "0x180E07C60")]
		public UIAtlasObject()
		{
		}

		// Token: 0x04019B98 RID: 105368
		[Token(Token = "0x4019B98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private List<AtlasSprite> _sprites;

		// Token: 0x04019B99 RID: 105369
		[Token(Token = "0x4019B99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AtlasInfo> _atlases;

		// Token: 0x04019B9A RID: 105370
		[Token(Token = "0x4019B9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("AssetPath of work dir. Null if to use the obj's current dir.")]
		private string _workDir;

		// Token: 0x04019B9B RID: 105371
		[Token(Token = "0x4019B9B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _alphaSplit;

		// Token: 0x04019B9C RID: 105372
		[Token(Token = "0x4019B9C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AtlasSize _maxSize;

		// Token: 0x04019B9D RID: 105373
		[Token(Token = "0x4019B9D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AtlasCheckInfo _sign;

		// Token: 0x04019B9E RID: 105374
		[Token(Token = "0x4019B9E")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, AtlasSprite> m_guidToSprite;

		// Token: 0x04019B9F RID: 105375
		[Token(Token = "0x4019B9F")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, AtlasSprite> m_nameToSprite;

		// Token: 0x04019BA0 RID: 105376
		[Token(Token = "0x4019BA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019BA1 RID: 105377
		[Token(Token = "0x4019BA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GUID2Sprite;

		// Token: 0x04019BA2 RID: 105378
		[Token(Token = "0x4019BA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSpriteByName;

		// Token: 0x04019BA3 RID: 105379
		[Token(Token = "0x4019BA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
