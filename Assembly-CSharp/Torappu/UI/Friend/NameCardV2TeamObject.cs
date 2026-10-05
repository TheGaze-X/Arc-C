using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E19 RID: 19993
	[Token(Token = "0x2004E19")]
	public class NameCardV2TeamObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DDE9 RID: 122345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDE9")]
		[Address(RVA = "0x177ABE0", Offset = "0x17797E0", VA = "0x18177ABE0")]
		public void Render(NameCardV2CollectModuleModel.NameCardTeamViewModel teamViewModel, Color collectedIconColor)
		{
		}

		// Token: 0x0601DDEA RID: 122346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDEA")]
		[Address(RVA = "0x177AD80", Offset = "0x1779980", VA = "0x18177AD80")]
		public NameCardV2TeamObject()
		{
		}

		// Token: 0x04027996 RID: 162198
		[Token(Token = "0x4027996")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _teamIcon;

		// Token: 0x04027997 RID: 162199
		[Token(Token = "0x4027997")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027998 RID: 162200
		[Token(Token = "0x4027998")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
