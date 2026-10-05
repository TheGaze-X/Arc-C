using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Gacha
{
	// Token: 0x02001648 RID: 5704
	[Token(Token = "0x2001648")]
	public class GachaDemo : MonoBehaviour
	{
		// Token: 0x0600815E RID: 33118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600815E")]
		[Address(RVA = "0x2B00C40", Offset = "0x2AFF840", VA = "0x182B00C40")]
		private void _PlayOne()
		{
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600815F")]
		[Address(RVA = "0x2B00E40", Offset = "0x2AFFA40", VA = "0x182B00E40")]
		private void _PlayTen()
		{
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x000388C8 File Offset: 0x00036AC8
		[Token(Token = "0x6008160")]
		[Address(RVA = "0x2B00B80", Offset = "0x2AFF780", VA = "0x182B00B80")]
		private GachaController.Input _CreateInput(GachaDemo.GachaConfig config)
		{
			return default(GachaController.Input);
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008161")]
		[Address(RVA = "0x2B00840", Offset = "0x2AFF440", VA = "0x182B00840")]
		private void OnGUI()
		{
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008162")]
		[Address(RVA = "0x2B011A0", Offset = "0x2AFFDA0", VA = "0x182B011A0")]
		public GachaDemo()
		{
		}

		// Token: 0x04008333 RID: 33587
		[Token(Token = "0x4008333")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GachaController.PlayMode _playMode;

		// Token: 0x04008334 RID: 33588
		[Token(Token = "0x4008334")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GachaDemo.GachaConfig _one;

		// Token: 0x04008335 RID: 33589
		[Token(Token = "0x4008335")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Collection(10)]
		private GachaDemo.GachaConfig[] _ten;

		// Token: 0x02001649 RID: 5705
		[Token(Token = "0x2001649")]
		[Serializable]
		private struct GachaConfig
		{
			// Token: 0x06008163 RID: 33123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008163")]
			[Address(RVA = "0x2AFACB0", Offset = "0x2AF98B0", VA = "0x182AFACB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04008336 RID: 33590
			[Token(Token = "0x4008336")]
			[FieldOffset(Offset = "0x0")]
			public string characterId;

			// Token: 0x04008337 RID: 33591
			[Token(Token = "0x4008337")]
			[FieldOffset(Offset = "0x8")]
			public EvolvePhase evolvePhase;

			// Token: 0x04008338 RID: 33592
			[Token(Token = "0x4008338")]
			[FieldOffset(Offset = "0xC")]
			public bool isNew;

			// Token: 0x04008339 RID: 33593
			[Token(Token = "0x4008339")]
			[FieldOffset(Offset = "0xD")]
			public bool isSkippable;
		}
	}
}
