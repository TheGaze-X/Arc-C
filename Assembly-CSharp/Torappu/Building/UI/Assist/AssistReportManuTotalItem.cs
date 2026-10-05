using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E09 RID: 7689
	[Token(Token = "0x2001E09")]
	public class AssistReportManuTotalItem : MonoBehaviour
	{
		// Token: 0x0600BDD3 RID: 48595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD3")]
		[Address(RVA = "0x33C14C0", Offset = "0x33C00C0", VA = "0x1833C14C0")]
		public void Render(ItemType itemType, int count)
		{
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AssistReportManuTotalItem()
		{
		}

		// Token: 0x0400BE85 RID: 48773
		[Token(Token = "0x400BE85")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _expPart;

		// Token: 0x0400BE86 RID: 48774
		[Token(Token = "0x400BE86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _goldPart;

		// Token: 0x0400BE87 RID: 48775
		[Token(Token = "0x400BE87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _expPartText;

		// Token: 0x0400BE88 RID: 48776
		[Token(Token = "0x400BE88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _goldPartText;

		// Token: 0x0400BE89 RID: 48777
		[Token(Token = "0x400BE89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _countText;
	}
}
