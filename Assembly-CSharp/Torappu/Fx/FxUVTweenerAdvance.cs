using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Fx
{
	// Token: 0x0200203C RID: 8252
	[Token(Token = "0x200203C")]
	[RequireComponent(typeof(Renderer))]
	public class FxUVTweenerAdvance : MonoBehaviour
	{
		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x0600CB60 RID: 52064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001818")]
		private Material activeMaterial
		{
			[Token(Token = "0x600CB60")]
			[Address(RVA = "0x34C5BD0", Offset = "0x34C47D0", VA = "0x1834C5BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001819")]
		private string secondMapPropertyName
		{
			[Token(Token = "0x600CB61")]
			[Address(RVA = "0x34C5CA0", Offset = "0x34C48A0", VA = "0x1834C5CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CB62 RID: 52066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB62")]
		[Address(RVA = "0x34C5270", Offset = "0x34C3E70", VA = "0x1834C5270")]
		private void Awake()
		{
		}

		// Token: 0x0600CB63 RID: 52067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB63")]
		[Address(RVA = "0x34C5580", Offset = "0x34C4180", VA = "0x1834C5580")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB64 RID: 52068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB64")]
		[Address(RVA = "0x34C5780", Offset = "0x34C4380", VA = "0x1834C5780")]
		private void Update()
		{
		}

		// Token: 0x0600CB65 RID: 52069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB65")]
		[Address(RVA = "0x34C5510", Offset = "0x34C4110", VA = "0x1834C5510")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CB66 RID: 52070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB66")]
		[Address(RVA = "0x34C5B10", Offset = "0x34C4710", VA = "0x1834C5B10")]
		public FxUVTweenerAdvance()
		{
		}

		// Token: 0x0400D58C RID: 54668
		[Token(Token = "0x400D58C")]
		private const string MATERIAL_KEY = "FX_UV_TWEENER";

		// Token: 0x0400D58D RID: 54669
		[Token(Token = "0x400D58D")]
		private const float SPEED_SCALE = 2f;

		// Token: 0x0400D58E RID: 54670
		[Token(Token = "0x400D58E")]
		[FieldOffset(Offset = "0x18")]
		public bool tweenRepeat;

		// Token: 0x0400D58F RID: 54671
		[Token(Token = "0x400D58F")]
		[FieldOffset(Offset = "0x1C")]
		public float tweenAnmTime;

		// Token: 0x0400D590 RID: 54672
		[Token(Token = "0x400D590")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("动画是否从设置的初始位移开始播放, 是的话勾一下")]
		public bool keepInitOffset;

		// Token: 0x0400D591 RID: 54673
		[Token(Token = "0x400D591")]
		[FieldOffset(Offset = "0x21")]
		public bool useSharedMaterial;

		// Token: 0x0400D592 RID: 54674
		[Token(Token = "0x400D592")]
		[FieldOffset(Offset = "0x24")]
		public float xspeed;

		// Token: 0x0400D593 RID: 54675
		[Token(Token = "0x400D593")]
		[FieldOffset(Offset = "0x28")]
		public float yspeed;

		// Token: 0x0400D594 RID: 54676
		[Token(Token = "0x400D594")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public bool useSecondMap;

		// Token: 0x0400D595 RID: 54677
		[Token(Token = "0x400D595")]
		[FieldOffset(Offset = "0x30")]
		public string secondMapName;

		// Token: 0x0400D596 RID: 54678
		[Token(Token = "0x400D596")]
		[FieldOffset(Offset = "0x38")]
		public float secondXSpeed;

		// Token: 0x0400D597 RID: 54679
		[Token(Token = "0x400D597")]
		[FieldOffset(Offset = "0x3C")]
		public float secondYSpeed;

		// Token: 0x0400D598 RID: 54680
		[Token(Token = "0x400D598")]
		[FieldOffset(Offset = "0x40")]
		public List<FxUVTweenerAdvance.UVTweenerMapSetting> extraMapSettings;

		// Token: 0x0400D599 RID: 54681
		[Token(Token = "0x400D599")]
		[FieldOffset(Offset = "0x48")]
		private float m_time;

		// Token: 0x0400D59A RID: 54682
		[Token(Token = "0x400D59A")]
		[FieldOffset(Offset = "0x50")]
		private Material m_sharedMaterial;

		// Token: 0x0400D59B RID: 54683
		[Token(Token = "0x400D59B")]
		[FieldOffset(Offset = "0x58")]
		private Renderer m_renderer;

		// Token: 0x0400D59C RID: 54684
		[Token(Token = "0x400D59C")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_v2;

		// Token: 0x0400D59D RID: 54685
		[Token(Token = "0x400D59D")]
		[FieldOffset(Offset = "0x68")]
		private Vector4 m_secondMapST;

		// Token: 0x0400D59E RID: 54686
		[Token(Token = "0x400D59E")]
		[FieldOffset(Offset = "0x78")]
		private string m_secondMapSTProp;

		// Token: 0x0400D59F RID: 54687
		[Token(Token = "0x400D59F")]
		[FieldOffset(Offset = "0x80")]
		private Material m_activeMaterial;

		// Token: 0x0200203D RID: 8253
		[Token(Token = "0x200203D")]
		[Serializable]
		public class UVTweenerMapSetting
		{
			// Token: 0x1700181A RID: 6170
			// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700181A")]
			public string mapSTProp
			{
				[Token(Token = "0x600CB67")]
				[Address(RVA = "0x34CF680", Offset = "0x34CE280", VA = "0x1834CF680")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600CB68 RID: 52072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CB68")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UVTweenerMapSetting()
			{
			}

			// Token: 0x0400D5A0 RID: 54688
			[Token(Token = "0x400D5A0")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public bool enabled;

			// Token: 0x0400D5A1 RID: 54689
			[Token(Token = "0x400D5A1")]
			[FieldOffset(Offset = "0x18")]
			public string mapName;

			// Token: 0x0400D5A2 RID: 54690
			[Token(Token = "0x400D5A2")]
			[FieldOffset(Offset = "0x20")]
			public float XSpeed;

			// Token: 0x0400D5A3 RID: 54691
			[Token(Token = "0x400D5A3")]
			[FieldOffset(Offset = "0x24")]
			public float YSpeed;

			// Token: 0x0400D5A4 RID: 54692
			[Token(Token = "0x400D5A4")]
			[FieldOffset(Offset = "0x28")]
			[HideInInspector]
			public Vector4 mapST;

			// Token: 0x0400D5A5 RID: 54693
			[Token(Token = "0x400D5A5")]
			[FieldOffset(Offset = "0x38")]
			private string m_mapSTProp;
		}
	}
}
