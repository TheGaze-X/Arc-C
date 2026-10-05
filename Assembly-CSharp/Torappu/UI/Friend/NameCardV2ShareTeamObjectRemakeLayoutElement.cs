using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DE3 RID: 19939
	[Token(Token = "0x2004DE3")]
	public class NameCardV2ShareTeamObjectRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DCF4 RID: 122100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCF4")]
		[Address(RVA = "0x1767AA0", Offset = "0x17666A0", VA = "0x181767AA0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DCF5 RID: 122101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCF5")]
		[Address(RVA = "0x1767BE0", Offset = "0x17667E0", VA = "0x181767BE0")]
		public NameCardV2ShareTeamObjectRemakeLayoutElement()
		{
		}

		// Token: 0x0402779C RID: 161692
		[Token(Token = "0x402779C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _teamIcon;

		// Token: 0x0402779D RID: 161693
		[Token(Token = "0x402779D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0402779E RID: 161694
		[Token(Token = "0x402779E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
