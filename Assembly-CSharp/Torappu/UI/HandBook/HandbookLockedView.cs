using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200669D RID: 26269
	[Token(Token = "0x200669D")]
	public class HandbookLockedView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025BC1 RID: 154561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC1")]
		[Address(RVA = "0x20B43E0", Offset = "0x20B2FE0", VA = "0x1820B43E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025BC2 RID: 154562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC2")]
		[Address(RVA = "0x20B3780", Offset = "0x20B2380", VA = "0x1820B3780")]
		private void OnEnable()
		{
		}

		// Token: 0x06025BC3 RID: 154563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC3")]
		[Address(RVA = "0x20B3C90", Offset = "0x20B2890", VA = "0x1820B3C90")]
		public void SetText(string charId, DataUnlockType type, string text, [Optional] string param1, [Optional] string param2, [Optional] string param3)
		{
		}

		// Token: 0x06025BC4 RID: 154564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC4")]
		[Address(RVA = "0x20B3970", Offset = "0x20B2570", VA = "0x1820B3970")]
		public void SetTextSplit(string charId, DataUnlockType type, string param, [Optional] string overrideString)
		{
		}

		// Token: 0x06025BC5 RID: 154565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC5")]
		[Address(RVA = "0x20B35F0", Offset = "0x20B21F0", VA = "0x1820B35F0")]
		public void OnAppear()
		{
		}

		// Token: 0x06025BC6 RID: 154566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC6")]
		[Address(RVA = "0x20B34E0", Offset = "0x20B20E0", VA = "0x1820B34E0")]
		public void DisAppearWithIndex(int openIndex)
		{
		}

		// Token: 0x06025BC7 RID: 154567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC7")]
		[Address(RVA = "0x20B3560", Offset = "0x20B2160", VA = "0x1820B3560")]
		public void DisAppear()
		{
		}

		// Token: 0x06025BC8 RID: 154568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC8")]
		[Address(RVA = "0x20B4210", Offset = "0x20B2E10", VA = "0x1820B4210")]
		public void SetUnlockParam(List<HandBookUnlockInfo> paramList, List<ItemBundle> rewardList, string title)
		{
		}

		// Token: 0x06025BC9 RID: 154569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BC9")]
		[Address(RVA = "0x20B3F60", Offset = "0x20B2B60", VA = "0x1820B3F60")]
		public void SetText(string charId, DataUnlockType type, List<CharWordUnlockParam> param, [Optional] string overrideString)
		{
		}

		// Token: 0x06025BCA RID: 154570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BCA")]
		[Address(RVA = "0x20B37E0", Offset = "0x20B23E0", VA = "0x1820B37E0")]
		public void SetAbleToUnlock(HandBookAvgGroupViewModel viewModel)
		{
		}

		// Token: 0x06025BCB RID: 154571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BCB")]
		[Address(RVA = "0x20B36E0", Offset = "0x20B22E0", VA = "0x1820B36E0")]
		public void OnClick()
		{
		}

		// Token: 0x06025BCC RID: 154572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BCC")]
		[Address(RVA = "0x20B4540", Offset = "0x20B3140", VA = "0x1820B4540")]
		public HandbookLockedView()
		{
		}

		// Token: 0x04035077 RID: 217207
		[Token(Token = "0x4035077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04035078 RID: 217208
		[Token(Token = "0x4035078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unlockAllPart;

		// Token: 0x04035079 RID: 217209
		[Token(Token = "0x4035079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedAllPart;

		// Token: 0x0403507A RID: 217210
		[Token(Token = "0x403507A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _wrapper;

		// Token: 0x0403507B RID: 217211
		[Token(Token = "0x403507B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hasRewardPart;

		// Token: 0x0403507C RID: 217212
		[Token(Token = "0x403507C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rewardPart;

		// Token: 0x0403507D RID: 217213
		[Token(Token = "0x403507D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x0403507E RID: 217214
		[Token(Token = "0x403507E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _scale;

		// Token: 0x0403507F RID: 217215
		[Token(Token = "0x403507F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _titlePart;

		// Token: 0x04035080 RID: 217216
		[Token(Token = "0x4035080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04035081 RID: 217217
		[Token(Token = "0x4035081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _rewardTinyIcon;

		// Token: 0x04035082 RID: 217218
		[Token(Token = "0x4035082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public int index;

		// Token: 0x04035083 RID: 217219
		[Token(Token = "0x4035083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public UIStringEvent onClickGroup;

		// Token: 0x04035084 RID: 217220
		[Token(Token = "0x4035084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<int> onDetailShow;

		// Token: 0x04035085 RID: 217221
		[Token(Token = "0x4035085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private HandbookUnlockAdapter m_adapter;

		// Token: 0x04035086 RID: 217222
		[Token(Token = "0x4035086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HandbookRewardAdapter m_rewardAdapter;

		// Token: 0x04035087 RID: 217223
		[Token(Token = "0x4035087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private HandBookAvgGroupViewModel m_cacheViewModel;

		// Token: 0x04035088 RID: 217224
		[Token(Token = "0x4035088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04035089 RID: 217225
		[Token(Token = "0x4035089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool m_hasReward;

		// Token: 0x0403508A RID: 217226
		[Token(Token = "0x403508A")]
		private const string REWARD_SHOW = "handbook_reward_show";

		// Token: 0x0403508B RID: 217227
		[Token(Token = "0x403508B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403508C RID: 217228
		[Token(Token = "0x403508C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403508D RID: 217229
		[Token(Token = "0x403508D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetText;

		// Token: 0x0403508E RID: 217230
		[Token(Token = "0x403508E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetTextSplit;

		// Token: 0x0403508F RID: 217231
		[Token(Token = "0x403508F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAppear;

		// Token: 0x04035090 RID: 217232
		[Token(Token = "0x4035090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DisAppearWithIndex;

		// Token: 0x04035091 RID: 217233
		[Token(Token = "0x4035091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DisAppear;

		// Token: 0x04035092 RID: 217234
		[Token(Token = "0x4035092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetUnlockParam;

		// Token: 0x04035093 RID: 217235
		[Token(Token = "0x4035093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_SetText;

		// Token: 0x04035094 RID: 217236
		[Token(Token = "0x4035094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetAbleToUnlock;

		// Token: 0x04035095 RID: 217237
		[Token(Token = "0x4035095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04035096 RID: 217238
		[Token(Token = "0x4035096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
