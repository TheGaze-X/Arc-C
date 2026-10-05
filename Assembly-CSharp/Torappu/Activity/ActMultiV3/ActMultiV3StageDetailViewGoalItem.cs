using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FE0 RID: 28640
	[Token(Token = "0x2006FE0")]
	public class ActMultiV3StageDetailViewGoalItem : MonoBehaviour
	{
		// Token: 0x06028ACF RID: 166607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ACF")]
		[Address(RVA = "0x23FCC60", Offset = "0x23FB860", VA = "0x1823FCC60")]
		public void Render(ActMultiV3StageDetailViewGoalItem.Param param, Sprite itemSprite)
		{
		}

		// Token: 0x06028AD0 RID: 166608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AD0")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ActMultiV3StageDetailViewGoalItem()
		{
		}

		// Token: 0x04039F5D RID: 237405
		[Token(Token = "0x4039F5D")]
		private const string REWARD_FORMAT = "+{0}";

		// Token: 0x04039F5E RID: 237406
		[Token(Token = "0x4039F5E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _goalTxt;

		// Token: 0x04039F5F RID: 237407
		[Token(Token = "0x4039F5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _rewardCntTxt;

		// Token: 0x04039F60 RID: 237408
		[Token(Token = "0x4039F60")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _nextArrowObj;

		// Token: 0x04039F61 RID: 237409
		[Token(Token = "0x4039F61")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _itemIconImg;

		// Token: 0x02006FE1 RID: 28641
		[Token(Token = "0x2006FE1")]
		public class Param
		{
			// Token: 0x06028AD1 RID: 166609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028AD1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04039F62 RID: 237410
			[Token(Token = "0x4039F62")]
			[FieldOffset(Offset = "0x10")]
			public string goalDesc;

			// Token: 0x04039F63 RID: 237411
			[Token(Token = "0x4039F63")]
			[FieldOffset(Offset = "0x18")]
			public int rewardCnt;

			// Token: 0x04039F64 RID: 237412
			[Token(Token = "0x4039F64")]
			[FieldOffset(Offset = "0x1C")]
			public bool isLast;
		}
	}
}
