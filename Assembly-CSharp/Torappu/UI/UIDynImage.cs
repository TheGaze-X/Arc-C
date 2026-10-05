using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037F4 RID: 14324
	[Token(Token = "0x20037F4")]
	[RequireComponent(typeof(Image))]
	public class UIDynImage : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x06016B2F RID: 92975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003644")]
		public Image target
		{
			[Token(Token = "0x6016B2F")]
			[Address(RVA = "0xF13B60", Offset = "0xF12760", VA = "0x180F13B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016B30 RID: 92976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016B30")]
		[Address(RVA = "0xF13160", Offset = "0xF11D60", VA = "0x180F13160")]
		public string ActivePath()
		{
			return null;
		}

		// Token: 0x06016B31 RID: 92977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B31")]
		[Address(RVA = "0xF13330", Offset = "0xF11F30", VA = "0x180F13330")]
		public void SetImage(string path, bool forceReload = false)
		{
		}

		// Token: 0x06016B32 RID: 92978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B32")]
		[Address(RVA = "0xF13220", Offset = "0xF11E20", VA = "0x180F13220")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x06016B33 RID: 92979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016B33")]
		[Address(RVA = "0xF137F0", Offset = "0xF123F0", VA = "0x180F137F0")]
		private Sprite _LoadSprite(string path)
		{
			return null;
		}

		// Token: 0x06016B34 RID: 92980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B34")]
		[Address(RVA = "0xF13930", Offset = "0xF12530", VA = "0x180F13930")]
		private void _UnloadImageIfNot()
		{
		}

		// Token: 0x06016B35 RID: 92981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B35")]
		[Address(RVA = "0xF13690", Offset = "0xF12290", VA = "0x180F13690")]
		private void _InitImageIfNot()
		{
		}

		// Token: 0x06016B36 RID: 92982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B36")]
		[Address(RVA = "0xF13630", Offset = "0xF12230", VA = "0x180F13630")]
		private void Start()
		{
		}

		// Token: 0x06016B37 RID: 92983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B37")]
		[Address(RVA = "0xF131C0", Offset = "0xF11DC0", VA = "0x180F131C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016B38 RID: 92984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B38")]
		[Address(RVA = "0xF13AD0", Offset = "0xF126D0", VA = "0x180F13AD0")]
		public UIDynImage()
		{
		}

		// Token: 0x0401B5BA RID: 112058
		[Token(Token = "0x401B5BA")]
		[FieldOffset(Offset = "0x18")]
		private Image m_image;

		// Token: 0x0401B5BB RID: 112059
		[Token(Token = "0x401B5BB")]
		[FieldOffset(Offset = "0x20")]
		private Sprite m_cachedSprite;

		// Token: 0x0401B5BC RID: 112060
		[Token(Token = "0x401B5BC")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedPath;

		// Token: 0x0401B5BD RID: 112061
		[Token(Token = "0x401B5BD")]
		[FieldOffset(Offset = "0x30")]
		private bool m_setCacheColor;

		// Token: 0x0401B5BE RID: 112062
		[Token(Token = "0x401B5BE")]
		[FieldOffset(Offset = "0x34")]
		private Color m_cacheColor;

		// Token: 0x0401B5BF RID: 112063
		[Token(Token = "0x401B5BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x0401B5C0 RID: 112064
		[Token(Token = "0x401B5C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ActivePath;

		// Token: 0x0401B5C1 RID: 112065
		[Token(Token = "0x401B5C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetImage;

		// Token: 0x0401B5C2 RID: 112066
		[Token(Token = "0x401B5C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x0401B5C3 RID: 112067
		[Token(Token = "0x401B5C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0401B5C4 RID: 112068
		[Token(Token = "0x401B5C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UnloadImageIfNot;

		// Token: 0x0401B5C5 RID: 112069
		[Token(Token = "0x401B5C5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitImageIfNot;

		// Token: 0x0401B5C6 RID: 112070
		[Token(Token = "0x401B5C6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B5C7 RID: 112071
		[Token(Token = "0x401B5C7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B5C8 RID: 112072
		[Token(Token = "0x401B5C8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
