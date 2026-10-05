using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034A4 RID: 13476
	[Token(Token = "0x20034A4")]
	[CreateAssetMenu(menuName = "Torappu/Atlas/UIAtlasSpriteHub")]
	public class UIAtlasSpriteHub : ScriptableObject, IHotfixable
	{
		// Token: 0x060157C8 RID: 88008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157C8")]
		[Address(RVA = "0xE07DC0", Offset = "0xE069C0", VA = "0x180E07DC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060157C9 RID: 88009 RVA: 0x0008C340 File Offset: 0x0008A540
		[Token(Token = "0x60157C9")]
		[Address(RVA = "0xE07CD0", Offset = "0xE068D0", VA = "0x180E07CD0")]
		public bool TryGetAtlasPath(string id, out string resPath)
		{
			return default(bool);
		}

		// Token: 0x060157CA RID: 88010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157CA")]
		[Address(RVA = "0xE07FA0", Offset = "0xE06BA0", VA = "0x180E07FA0")]
		public UIAtlasSpriteHub()
		{
		}

		// Token: 0x04019BA4 RID: 105380
		[Token(Token = "0x4019BA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private List<UIAtlasSpriteHub.HubItem> _sprites;

		// Token: 0x04019BA5 RID: 105381
		[Token(Token = "0x4019BA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		[Tooltip("Path list of maintained atlases.")]
		private List<string> _atlases;

		// Token: 0x04019BA6 RID: 105382
		[Token(Token = "0x4019BA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("AssetPath of the directory of maintained sprites.")]
		private string _inputSpriteDir;

		// Token: 0x04019BA7 RID: 105383
		[Token(Token = "0x4019BA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("AssetPath of the directory to save packed atlases ")]
		private string _outputAtlasDir;

		// Token: 0x04019BA8 RID: 105384
		[Token(Token = "0x4019BA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Atlas name format of created atlases.")]
		private string _rootAtlasName;

		// Token: 0x04019BA9 RID: 105385
		[Token(Token = "0x4019BA9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasSpriteHub.PicSize _spriteSize;

		// Token: 0x04019BAA RID: 105386
		[Token(Token = "0x4019BAA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("The accurate max value of sprite cnt in one atlas texture.")]
		private int _cntPerAtlas;

		// Token: 0x04019BAB RID: 105387
		[Token(Token = "0x4019BAB")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Tooltip("Note that the size should match _cntPerAtlas.")]
		private AtlasSize _maxAtlasSize;

		// Token: 0x04019BAC RID: 105388
		[Token(Token = "0x4019BAC")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> m_spriteToTexture;

		// Token: 0x04019BAD RID: 105389
		[Token(Token = "0x4019BAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019BAE RID: 105390
		[Token(Token = "0x4019BAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetAtlasPath;

		// Token: 0x04019BAF RID: 105391
		[Token(Token = "0x4019BAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034A5 RID: 13477
		[Token(Token = "0x20034A5")]
		[Serializable]
		private struct PicSize
		{
			// Token: 0x060157CB RID: 88011 RVA: 0x0008C358 File Offset: 0x0008A558
			[Token(Token = "0x60157CB")]
			[Address(RVA = "0xE05AC0", Offset = "0xE046C0", VA = "0x180E05AC0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x060157CC RID: 88012 RVA: 0x0008C370 File Offset: 0x0008A570
			[Token(Token = "0x60157CC")]
			[Address(RVA = "0xE05AD0", Offset = "0xE046D0", VA = "0x180E05AD0")]
			public bool Validate(Rect rect)
			{
				return default(bool);
			}

			// Token: 0x04019BB0 RID: 105392
			[Token(Token = "0x4019BB0")]
			[FieldOffset(Offset = "0x0")]
			public int width;

			// Token: 0x04019BB1 RID: 105393
			[Token(Token = "0x4019BB1")]
			[FieldOffset(Offset = "0x4")]
			public int height;
		}

		// Token: 0x020034A6 RID: 13478
		[Token(Token = "0x20034A6")]
		[Serializable]
		private struct HubItem
		{
			// Token: 0x04019BB2 RID: 105394
			[Token(Token = "0x4019BB2")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04019BB3 RID: 105395
			[Token(Token = "0x4019BB3")]
			[FieldOffset(Offset = "0x8")]
			public int atlas;
		}
	}
}
