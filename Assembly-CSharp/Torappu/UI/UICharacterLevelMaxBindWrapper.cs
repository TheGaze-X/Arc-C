using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200350F RID: 13583
	[Token(Token = "0x200350F")]
	public class UICharacterLevelMaxBindWrapper : MonoBehaviour, IDataBindWrapper, IHotfixable
	{
		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x06015A9D RID: 88733 RVA: 0x0008D5A0 File Offset: 0x0008B7A0
		[Token(Token = "0x1700337A")]
		public UplevelAttribute originAttribute
		{
			[Token(Token = "0x6015A9D")]
			[Address(RVA = "0xE3D470", Offset = "0xE3C070", VA = "0x180E3D470")]
			get
			{
				return default(UplevelAttribute);
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x06015A9E RID: 88734 RVA: 0x0008D5B8 File Offset: 0x0008B7B8
		[Token(Token = "0x1700337B")]
		public UplevelAttribute currentAttribute
		{
			[Token(Token = "0x6015A9E")]
			[Address(RVA = "0xE3D3F0", Offset = "0xE3BFF0", VA = "0x180E3D3F0")]
			get
			{
				return default(UplevelAttribute);
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x06015A9F RID: 88735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700337C")]
		public string powerId
		{
			[Token(Token = "0x6015A9F")]
			[Address(RVA = "0xE3D4F0", Offset = "0xE3C0F0", VA = "0x180E3D4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x06015AA0 RID: 88736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700337D")]
		public Sprite campLogo
		{
			[Token(Token = "0x6015AA0")]
			[Address(RVA = "0xE3D390", Offset = "0xE3BF90", VA = "0x180E3D390")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015AA1 RID: 88737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA1")]
		[Address(RVA = "0xE3CF70", Offset = "0xE3BB70", VA = "0x180E3CF70")]
		public void LoadData(int charInstId, int originLevel)
		{
		}

		// Token: 0x06015AA2 RID: 88738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA2")]
		[Address(RVA = "0xE3D2F0", Offset = "0xE3BEF0", VA = "0x180E3D2F0")]
		public UICharacterLevelMaxBindWrapper()
		{
		}

		// Token: 0x04019FCC RID: 106444
		[Token(Token = "0x4019FCC")]
		[FieldOffset(Offset = "0x18")]
		public CharacterIllustViewProperty illustProperty;

		// Token: 0x04019FCD RID: 106445
		[Token(Token = "0x4019FCD")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public EvolvePhase evolvePhase;

		// Token: 0x04019FCE RID: 106446
		[Token(Token = "0x4019FCE")]
		[FieldOffset(Offset = "0x24")]
		[NonSerialized]
		public int potentialRank;

		// Token: 0x04019FCF RID: 106447
		[Token(Token = "0x4019FCF")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public int currentLevel;

		// Token: 0x04019FD0 RID: 106448
		[Token(Token = "0x4019FD0")]
		[FieldOffset(Offset = "0x2C")]
		private int m_charInstId;

		// Token: 0x04019FD1 RID: 106449
		[Token(Token = "0x4019FD1")]
		[FieldOffset(Offset = "0x30")]
		private UplevelAttribute m_originAttr;

		// Token: 0x04019FD2 RID: 106450
		[Token(Token = "0x4019FD2")]
		[FieldOffset(Offset = "0x40")]
		private UplevelAttribute m_currentAttr;

		// Token: 0x04019FD3 RID: 106451
		[Token(Token = "0x4019FD3")]
		[FieldOffset(Offset = "0x50")]
		private string m_powerId;

		// Token: 0x04019FD4 RID: 106452
		[Token(Token = "0x4019FD4")]
		[FieldOffset(Offset = "0x58")]
		private Sprite m_campLogo;

		// Token: 0x04019FD5 RID: 106453
		[Token(Token = "0x4019FD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_originAttribute;

		// Token: 0x04019FD6 RID: 106454
		[Token(Token = "0x4019FD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentAttribute;

		// Token: 0x04019FD7 RID: 106455
		[Token(Token = "0x4019FD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_powerId;

		// Token: 0x04019FD8 RID: 106456
		[Token(Token = "0x4019FD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_campLogo;

		// Token: 0x04019FD9 RID: 106457
		[Token(Token = "0x4019FD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04019FDA RID: 106458
		[Token(Token = "0x4019FDA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
