using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2.BattleFinish
{
	// Token: 0x02004457 RID: 17495
	[Token(Token = "0x2004457")]
	public class SandboxV2BattleFinishRacerItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ABBB RID: 109499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABBB")]
		[Address(RVA = "0x13D9F00", Offset = "0x13D8B00", VA = "0x1813D9F00")]
		public void Render(SandboxV2RacerInfoModel racerModel, bool isMe)
		{
		}

		// Token: 0x0601ABBC RID: 109500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABBC")]
		[Address(RVA = "0x13DA170", Offset = "0x13D8D70", VA = "0x1813DA170")]
		public SandboxV2BattleFinishRacerItem()
		{
		}

		// Token: 0x0402225F RID: 139871
		[Token(Token = "0x402225F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04022260 RID: 139872
		[Token(Token = "0x4022260")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgRacer;

		// Token: 0x04022261 RID: 139873
		[Token(Token = "0x4022261")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _rankEmptyGo;

		// Token: 0x04022262 RID: 139874
		[Token(Token = "0x4022262")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _rankNormalGo;

		// Token: 0x04022263 RID: 139875
		[Token(Token = "0x4022263")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _otherRacerGo;

		// Token: 0x04022264 RID: 139876
		[Token(Token = "0x4022264")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _myRacerGo;

		// Token: 0x04022265 RID: 139877
		[Token(Token = "0x4022265")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorOtherRacerName;

		// Token: 0x04022266 RID: 139878
		[Token(Token = "0x4022266")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorMyRacerName;

		// Token: 0x04022267 RID: 139879
		[Token(Token = "0x4022267")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022268 RID: 139880
		[Token(Token = "0x4022268")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
