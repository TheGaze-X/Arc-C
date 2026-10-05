using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Grading
{
	// Token: 0x02001644 RID: 5700
	[Token(Token = "0x2001644")]
	public class PerformanceTest : MonoBehaviour
	{
		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06008151 RID: 33105 RVA: 0x00038898 File Offset: 0x00036A98
		// (set) Token: 0x06008152 RID: 33106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F51")]
		public PerformanceTest.DeviceLevel deviceLevel
		{
			[Token(Token = "0x6008151")]
			[Address(RVA = "0x1820C10", Offset = "0x181F810", VA = "0x181820C10")]
			[CompilerGenerated]
			get
			{
				return PerformanceTest.DeviceLevel.LOW;
			}
			[Token(Token = "0x6008152")]
			[Address(RVA = "0x2B0B050", Offset = "0x2B09C50", VA = "0x182B0B050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06008153 RID: 33107 RVA: 0x000388B0 File Offset: 0x00036AB0
		// (set) Token: 0x06008154 RID: 33108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000F52")]
		public float finalScore
		{
			[Token(Token = "0x6008153")]
			[Address(RVA = "0x1692770", Offset = "0x1691370", VA = "0x181692770")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6008154")]
			[Address(RVA = "0x1692BA0", Offset = "0x16917A0", VA = "0x181692BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008155")]
		[Address(RVA = "0x2B0AAD0", Offset = "0x2B096D0", VA = "0x182B0AAD0")]
		private void Start()
		{
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008156")]
		[Address(RVA = "0x2B0A5C0", Offset = "0x2B091C0", VA = "0x182B0A5C0")]
		private void OnPostRender()
		{
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008157")]
		[Address(RVA = "0x2B0AE60", Offset = "0x2B09A60", VA = "0x182B0AE60")]
		private void _Draw(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008158")]
		[Address(RVA = "0x2B0ACB0", Offset = "0x2B098B0", VA = "0x182B0ACB0")]
		private void _DrawQuads()
		{
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008159")]
		[Address(RVA = "0x2B0AB00", Offset = "0x2B09700", VA = "0x182B0AB00")]
		private void _CalculateLevel()
		{
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600815A")]
		[Address(RVA = "0x2B0AAB0", Offset = "0x2B096B0", VA = "0x182B0AAB0")]
		public void StartTest([Optional] Action onTestComplete)
		{
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600815B")]
		[Address(RVA = "0x2B0AFC0", Offset = "0x2B09BC0", VA = "0x182B0AFC0")]
		public PerformanceTest()
		{
		}

		// Token: 0x04008317 RID: 33559
		[Token(Token = "0x4008317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _mat;

		// Token: 0x04008318 RID: 33560
		[Token(Token = "0x4008318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _buttomLeft;

		// Token: 0x04008319 RID: 33561
		[Token(Token = "0x4008319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _buttomRight;

		// Token: 0x0400831A RID: 33562
		[Token(Token = "0x400831A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _topLeft;

		// Token: 0x0400831B RID: 33563
		[Token(Token = "0x400831B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _topRight;

		// Token: 0x0400831C RID: 33564
		[Token(Token = "0x400831C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _sampleCount;

		// Token: 0x0400831D RID: 33565
		[Token(Token = "0x400831D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int _drawCountPerFrame;

		// Token: 0x0400831E RID: 33566
		[Token(Token = "0x400831E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _standardScore;

		// Token: 0x0400831F RID: 33567
		[Token(Token = "0x400831F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _maxRenderTime;

		// Token: 0x04008320 RID: 33568
		[Token(Token = "0x4008320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PerformanceTest.PerformanceTestState m_state;

		// Token: 0x04008321 RID: 33569
		[Token(Token = "0x4008321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_frameCount;

		// Token: 0x04008322 RID: 33570
		[Token(Token = "0x4008322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_totalDrawMilliseconds;

		// Token: 0x04008323 RID: 33571
		[Token(Token = "0x4008323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float m_startTimestemp;

		// Token: 0x04008324 RID: 33572
		[Token(Token = "0x4008324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<float> m_scoreList;

		// Token: 0x04008325 RID: 33573
		[Token(Token = "0x4008325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_width;

		// Token: 0x04008326 RID: 33574
		[Token(Token = "0x4008326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_height;

		// Token: 0x04008327 RID: 33575
		[Token(Token = "0x4008327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action m_onTestComplete;

		// Token: 0x02001645 RID: 5701
		[Token(Token = "0x2001645")]
		public enum PerformanceTestState
		{
			// Token: 0x0400832B RID: 33579
			[Token(Token = "0x400832B")]
			IDLE,
			// Token: 0x0400832C RID: 33580
			[Token(Token = "0x400832C")]
			START,
			// Token: 0x0400832D RID: 33581
			[Token(Token = "0x400832D")]
			END
		}

		// Token: 0x02001646 RID: 5702
		[Token(Token = "0x2001646")]
		public enum DeviceLevel
		{
			// Token: 0x0400832F RID: 33583
			[Token(Token = "0x400832F")]
			NODEFINE = -1,
			// Token: 0x04008330 RID: 33584
			[Token(Token = "0x4008330")]
			LOW,
			// Token: 0x04008331 RID: 33585
			[Token(Token = "0x4008331")]
			HIGH
		}
	}
}
