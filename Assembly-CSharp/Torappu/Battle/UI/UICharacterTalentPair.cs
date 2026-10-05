using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003375 RID: 13173
	[Token(Token = "0x2003375")]
	public class UICharacterTalentPair : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015041 RID: 86081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015041")]
		[Address(RVA = "0xD6EB50", Offset = "0xD6D750", VA = "0x180D6EB50")]
		public void UpdateLayout(string talentName, string talentDescription)
		{
		}

		// Token: 0x06015042 RID: 86082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015042")]
		[Address(RVA = "0xD6EC50", Offset = "0xD6D850", VA = "0x180D6EC50")]
		public UICharacterTalentPair()
		{
		}

		// Token: 0x0401901B RID: 102427
		[Token(Token = "0x401901B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _talentName;

		// Token: 0x0401901C RID: 102428
		[Token(Token = "0x401901C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _talentDescription;

		// Token: 0x0401901D RID: 102429
		[Token(Token = "0x401901D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLayout;

		// Token: 0x0401901E RID: 102430
		[Token(Token = "0x401901E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
