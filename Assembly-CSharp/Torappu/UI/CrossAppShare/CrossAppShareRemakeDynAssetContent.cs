using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F0 RID: 22768
	[Token(Token = "0x20058F0")]
	public class CrossAppShareRemakeDynAssetContent : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602131D RID: 135965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602131D")]
		[Address(RVA = "0x1B76C30", Offset = "0x1B75830", VA = "0x181B76C30")]
		public void ApplyDynAsset(CrossAppShareDynAssetBaseModel dynAssetModel, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602131E RID: 135966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602131E")]
		[Address(RVA = "0x1B76ED0", Offset = "0x1B75AD0", VA = "0x181B76ED0")]
		private void _ApplyAvatar(CrossAppShareAvatarModel avatarModel)
		{
		}

		// Token: 0x0602131F RID: 135967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602131F")]
		[Address(RVA = "0x1B77060", Offset = "0x1B75C60", VA = "0x181B77060")]
		private void _ApplyFriendMedal(CrossAppShareMedalModel medalModel)
		{
		}

		// Token: 0x06021320 RID: 135968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021320")]
		[Address(RVA = "0x1B772C0", Offset = "0x1B75EC0", VA = "0x181B772C0")]
		private void _ApplyIllust(CrossAppShareIllustModel illustModel)
		{
		}

		// Token: 0x06021321 RID: 135969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021321")]
		[Address(RVA = "0x1B77500", Offset = "0x1B76100", VA = "0x181B77500")]
		public CrossAppShareRemakeDynAssetContent()
		{
		}

		// Token: 0x0402D377 RID: 185207
		[Token(Token = "0x402D377")]
		[FieldOffset(Offset = "0x18")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x0402D378 RID: 185208
		[Token(Token = "0x402D378")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyDynAsset;

		// Token: 0x0402D379 RID: 185209
		[Token(Token = "0x402D379")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyAvatar;

		// Token: 0x0402D37A RID: 185210
		[Token(Token = "0x402D37A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyFriendMedal;

		// Token: 0x0402D37B RID: 185211
		[Token(Token = "0x402D37B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyIllust;

		// Token: 0x0402D37C RID: 185212
		[Token(Token = "0x402D37C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
