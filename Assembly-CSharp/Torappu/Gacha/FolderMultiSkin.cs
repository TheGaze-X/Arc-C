using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Torappu.Gacha
{
	// Token: 0x02001667 RID: 5735
	[Token(Token = "0x2001667")]
	public class FolderMultiSkin : MonoBehaviour
	{
		// Token: 0x06008213 RID: 33299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008213")]
		[Address(RVA = "0x2AFA6F0", Offset = "0x2AF92F0", VA = "0x182AFA6F0")]
		public void LoadSkin(IList<RarityRank> rarityList)
		{
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008214")]
		[Address(RVA = "0x2AFA9A0", Offset = "0x2AF95A0", VA = "0x182AFA9A0")]
		public FolderMultiSkin()
		{
		}

		// Token: 0x04008429 RID: 33833
		[Token(Token = "0x4008429")]
		private const string CUSTOM_SKIN_NAME = "CUSTOM_SKIN";

		// Token: 0x0400842A RID: 33834
		[Token(Token = "0x400842A")]
		private const int PAGE_CNT = 10;

		// Token: 0x0400842B RID: 33835
		[Token(Token = "0x400842B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkeletonDataAsset _data;

		// Token: 0x0400842C RID: 33836
		[Token(Token = "0x400842C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkeletonAnimation _skeleton;

		// Token: 0x0400842D RID: 33837
		[Token(Token = "0x400842D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Collection(6)]
		private FolderMultiSkin.SkinSource[] _skins;

		// Token: 0x0400842E RID: 33838
		[Token(Token = "0x400842E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Collection(10)]
		private FolderMultiSkin.SkinPlaceholder[] _placeholders;

		// Token: 0x02001668 RID: 5736
		[Token(Token = "0x2001668")]
		[Serializable]
		private struct SkinSource
		{
			// Token: 0x0400842F RID: 33839
			[Token(Token = "0x400842F")]
			[FieldOffset(Offset = "0x0")]
			[SpineSkin("", "", true, false, false, dataField = "_data")]
			public string skin;
		}

		// Token: 0x02001669 RID: 5737
		[Token(Token = "0x2001669")]
		[Serializable]
		private struct SkinPlaceholder
		{
			// Token: 0x04008430 RID: 33840
			[Token(Token = "0x4008430")]
			[FieldOffset(Offset = "0x0")]
			[SpineSlot("", "", false, true, false, dataField = "_data")]
			public string slot;

			// Token: 0x04008431 RID: 33841
			[Token(Token = "0x4008431")]
			[FieldOffset(Offset = "0x8")]
			[SpineAttachment(true, false, false, "", "", "", true, false, currentSkinOnly = true, placeholdersOnly = true, dataField = "_data")]
			public string attachment;
		}
	}
}
