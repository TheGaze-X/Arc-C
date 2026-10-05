using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DBB RID: 19899
	[Token(Token = "0x2004DBB")]
	public class FriendSharedCharHeadIcon : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DC0C RID: 121868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC0C")]
		[Address(RVA = "0x1755370", Offset = "0x1753F70", VA = "0x181755370")]
		public void ApplyNullableData(SharedCharData charData)
		{
		}

		// Token: 0x0601DC0D RID: 121869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC0D")]
		[Address(RVA = "0x17555B0", Offset = "0x17541B0", VA = "0x1817555B0")]
		public void ApplyNullableData(int charInstId)
		{
		}

		// Token: 0x0601DC0E RID: 121870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC0E")]
		[Address(RVA = "0x1755130", Offset = "0x1753D30", VA = "0x181755130")]
		public void ApplyNullableData(PlayerCharacter charData)
		{
		}

		// Token: 0x0601DC0F RID: 121871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC0F")]
		[Address(RVA = "0x17556B0", Offset = "0x17542B0", VA = "0x1817556B0")]
		public FriendSharedCharHeadIcon()
		{
		}

		// Token: 0x040275BC RID: 161212
		[Token(Token = "0x40275BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _headIcon;

		// Token: 0x040275BD RID: 161213
		[Token(Token = "0x40275BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _eliteSprite;

		// Token: 0x040275BE RID: 161214
		[Token(Token = "0x40275BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _specMaxPart;

		// Token: 0x040275BF RID: 161215
		[Token(Token = "0x40275BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _level;

		// Token: 0x040275C0 RID: 161216
		[Token(Token = "0x40275C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _emptyToggle;

		// Token: 0x040275C1 RID: 161217
		[Token(Token = "0x40275C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyNullableData;

		// Token: 0x040275C2 RID: 161218
		[Token(Token = "0x40275C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_ApplyNullableData;

		// Token: 0x040275C3 RID: 161219
		[Token(Token = "0x40275C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix2_ApplyNullableData;

		// Token: 0x040275C4 RID: 161220
		[Token(Token = "0x40275C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
