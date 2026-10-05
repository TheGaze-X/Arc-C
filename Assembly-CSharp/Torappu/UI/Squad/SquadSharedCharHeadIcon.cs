using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E37 RID: 15927
	[Token(Token = "0x2003E37")]
	public class SquadSharedCharHeadIcon : MonoBehaviour
	{
		// Token: 0x06018C04 RID: 101380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C04")]
		[Address(RVA = "0x117F820", Offset = "0x117E420", VA = "0x18117F820")]
		public void ApplyData(SharedCharData charData)
		{
		}

		// Token: 0x06018C05 RID: 101381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C05")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SquadSharedCharHeadIcon()
		{
		}

		// Token: 0x0401E68C RID: 124556
		[Token(Token = "0x401E68C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _headIcon;

		// Token: 0x0401E68D RID: 124557
		[Token(Token = "0x401E68D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _headIcon_2;

		// Token: 0x0401E68E RID: 124558
		[Token(Token = "0x401E68E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _eliteSprite;

		// Token: 0x0401E68F RID: 124559
		[Token(Token = "0x401E68F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _eliteObject;

		// Token: 0x0401E690 RID: 124560
		[Token(Token = "0x401E690")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _level;

		// Token: 0x0401E691 RID: 124561
		[Token(Token = "0x401E691")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _skillLevel;

		// Token: 0x0401E692 RID: 124562
		[Token(Token = "0x401E692")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x0401E693 RID: 124563
		[Token(Token = "0x401E693")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _skillName;

		// Token: 0x0401E694 RID: 124564
		[Token(Token = "0x401E694")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _professionImage;

		// Token: 0x0401E695 RID: 124565
		[Token(Token = "0x401E695")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _skillSpecialPart;

		// Token: 0x0401E696 RID: 124566
		[Token(Token = "0x401E696")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _skillSpecialPic;

		// Token: 0x0401E697 RID: 124567
		[Token(Token = "0x401E697")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _charName;
	}
}
