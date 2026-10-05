using System;
using Il2CppDummyDll;
using Torappu.Battle.Legion;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032DE RID: 13022
	[Token(Token = "0x20032DE")]
	public class LegionUICharacterTabDetailItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06014B46 RID: 84806 RVA: 0x000880B0 File Offset: 0x000862B0
		[Token(Token = "0x17003106")]
		public ProfessionCategory currentProfession
		{
			[Token(Token = "0x6014B46")]
			[Address(RVA = "0xD1AF20", Offset = "0xD19B20", VA = "0x180D1AF20")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x06014B47 RID: 84807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B47")]
		[Address(RVA = "0xD1A8E0", Offset = "0xD194E0", VA = "0x180D1A8E0")]
		public void SetData(LegionModeProfessionBuffStatus detail)
		{
		}

		// Token: 0x06014B48 RID: 84808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B48")]
		[Address(RVA = "0xD1ABE0", Offset = "0xD197E0", VA = "0x180D1ABE0")]
		public void ShowHighLight()
		{
		}

		// Token: 0x06014B49 RID: 84809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B49")]
		[Address(RVA = "0xD1AD80", Offset = "0xD19980", VA = "0x180D1AD80")]
		private void _SetProfessionIcon(Image professionImage, ProfessionCategory profession, LegionUICharacterTabDetailItem.ProfessionSpritePair[] professionIcons)
		{
		}

		// Token: 0x06014B4A RID: 84810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B4A")]
		[Address(RVA = "0xD1AE90", Offset = "0xD19A90", VA = "0x180D1AE90")]
		public LegionUICharacterTabDetailItem()
		{
		}

		// Token: 0x04018963 RID: 100707
		[Token(Token = "0x4018963")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _levelLabel;

		// Token: 0x04018964 RID: 100708
		[Token(Token = "0x4018964")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _descriptionLabel;

		// Token: 0x04018965 RID: 100709
		[Token(Token = "0x4018965")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _professionImage;

		// Token: 0x04018966 RID: 100710
		[Token(Token = "0x4018966")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LegionUICharacterTabDetailItem.ProfessionSpritePair[] _professionIcons;

		// Token: 0x04018967 RID: 100711
		[Token(Token = "0x4018967")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image[] _highLightImages;

		// Token: 0x04018968 RID: 100712
		[Token(Token = "0x4018968")]
		[FieldOffset(Offset = "0x40")]
		private ProfessionCategory m_currentProfession;

		// Token: 0x04018969 RID: 100713
		[Token(Token = "0x4018969")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentProfession;

		// Token: 0x0401896A RID: 100714
		[Token(Token = "0x401896A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401896B RID: 100715
		[Token(Token = "0x401896B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowHighLight;

		// Token: 0x0401896C RID: 100716
		[Token(Token = "0x401896C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetProfessionIcon;

		// Token: 0x0401896D RID: 100717
		[Token(Token = "0x401896D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032DF RID: 13023
		[Token(Token = "0x20032DF")]
		[Serializable]
		private struct ProfessionSpritePair
		{
			// Token: 0x0401896E RID: 100718
			[Token(Token = "0x401896E")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x0401896F RID: 100719
			[Token(Token = "0x401896F")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}
	}
}
