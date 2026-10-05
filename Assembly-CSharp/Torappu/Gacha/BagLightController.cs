using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Audio.Middleware;
using UnityEngine;

namespace Torappu.Gacha
{
	// Token: 0x02001665 RID: 5733
	[Token(Token = "0x2001665")]
	public class BagLightController : MonoBehaviour
	{
		// Token: 0x0600820C RID: 33292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820C")]
		[Address(RVA = "0x2AF7FA0", Offset = "0x2AF6BA0", VA = "0x182AF7FA0")]
		public void OnEnter()
		{
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820D")]
		[Address(RVA = "0x2AF8060", Offset = "0x2AF6C60", VA = "0x182AF8060")]
		public void OnExit()
		{
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820E")]
		[Address(RVA = "0x2AF8230", Offset = "0x2AF6E30", VA = "0x182AF8230")]
		public void UpdatePillars(float progress)
		{
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820F")]
		[Address(RVA = "0x2AF80F0", Offset = "0x2AF6CF0", VA = "0x182AF80F0")]
		public void PreloadAudioSignals()
		{
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008210")]
		[Address(RVA = "0x2AF8440", Offset = "0x2AF7040", VA = "0x182AF8440")]
		private void _SetAllActive(bool active)
		{
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008211")]
		[Address(RVA = "0x2AF84C0", Offset = "0x2AF70C0", VA = "0x182AF84C0")]
		private void _SetPadSeVolumn(float progress)
		{
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008212")]
		[Address(RVA = "0x2AF8590", Offset = "0x2AF7190", VA = "0x182AF8590")]
		public BagLightController()
		{
		}

		// Token: 0x04008421 RID: 33825
		[Token(Token = "0x4008421")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BagLightController.LightPillar[] _pillars;

		// Token: 0x04008422 RID: 33826
		[Token(Token = "0x4008422")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Pad SE")]
		private string _padAudioSignal;

		// Token: 0x04008423 RID: 33827
		[Token(Token = "0x4008423")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Pad SE")]
		private Vector2 _padProgressRange;

		// Token: 0x04008424 RID: 33828
		[Token(Token = "0x4008424")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Pad SE")]
		private Vector2 _padVolumeLevelRange;

		// Token: 0x04008425 RID: 33829
		[Token(Token = "0x4008425")]
		[FieldOffset(Offset = "0x38")]
		private AudioAtom[] m_atoms;

		// Token: 0x02001666 RID: 5734
		[Token(Token = "0x2001666")]
		[Serializable]
		public struct LightPillar
		{
			// Token: 0x04008426 RID: 33830
			[Token(Token = "0x4008426")]
			[FieldOffset(Offset = "0x0")]
			public float minProgress;

			// Token: 0x04008427 RID: 33831
			[Token(Token = "0x4008427")]
			[FieldOffset(Offset = "0x8")]
			public GameObject gameObject;

			// Token: 0x04008428 RID: 33832
			[Token(Token = "0x4008428")]
			[FieldOffset(Offset = "0x10")]
			public string audioSignal;
		}
	}
}
