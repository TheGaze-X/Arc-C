using System;
using Il2CppDummyDll;
using Torappu.Multiplayer.Servers;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EFE RID: 28414
	[Token(Token = "0x2006EFE")]
	public class ActMultiV3ShortNameCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060285E0 RID: 165344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E0")]
		[Address(RVA = "0x23BB6C0", Offset = "0x23BA2C0", VA = "0x1823BB6C0")]
		public void Render(string actId, TeamProtocol.STPlayerStatus playerStatus, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060285E1 RID: 165345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E1")]
		[Address(RVA = "0x23BB620", Offset = "0x23BA220", VA = "0x1823BB620")]
		public void Render(ActMultiV3NameCardParam param, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060285E2 RID: 165346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E2")]
		[Address(RVA = "0x23BB8F0", Offset = "0x23BA4F0", VA = "0x1823BB8F0")]
		private void _Render(ActMultiV3NameCardParam param, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060285E3 RID: 165347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285E3")]
		[Address(RVA = "0x23BBC30", Offset = "0x23BA830", VA = "0x1823BBC30")]
		public ActMultiV3ShortNameCardView()
		{
		}

		// Token: 0x0403964A RID: 235082
		[Token(Token = "0x403964A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x0403964B RID: 235083
		[Token(Token = "0x403964B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x0403964C RID: 235084
		[Token(Token = "0x403964C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _doctorUidGO;

		// Token: 0x0403964D RID: 235085
		[Token(Token = "0x403964D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x0403964E RID: 235086
		[Token(Token = "0x403964E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _doctorTitle;

		// Token: 0x0403964F RID: 235087
		[Token(Token = "0x403964F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x04039650 RID: 235088
		[Token(Token = "0x4039650")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _mentorObj;

		// Token: 0x04039651 RID: 235089
		[Token(Token = "0x4039651")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _earlyQuitMaskGO;

		// Token: 0x04039652 RID: 235090
		[Token(Token = "0x4039652")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _avatarViewContainer;

		// Token: 0x04039653 RID: 235091
		[Token(Token = "0x4039653")]
		[FieldOffset(Offset = "0x60")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04039654 RID: 235092
		[Token(Token = "0x4039654")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039655 RID: 235093
		[Token(Token = "0x4039655")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x04039656 RID: 235094
		[Token(Token = "0x4039656")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04039657 RID: 235095
		[Token(Token = "0x4039657")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
