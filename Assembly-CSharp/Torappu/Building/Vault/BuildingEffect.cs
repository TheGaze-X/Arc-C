using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A0C RID: 6668
	[Token(Token = "0x2001A0C")]
	public class BuildingEffect : MonoBehaviour
	{
		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x0600A729 RID: 42793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001348")]
		protected ParticleSystem particleSystem
		{
			[Token(Token = "0x600A729")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x0600A72A RID: 42794 RVA: 0x00040B18 File Offset: 0x0003ED18
		[Token(Token = "0x17001349")]
		private bool isValid
		{
			[Token(Token = "0x600A72A")]
			[Address(RVA = "0x3218E90", Offset = "0x3217A90", VA = "0x183218E90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A72B")]
		[Address(RVA = "0x3218860", Offset = "0x3217460", VA = "0x183218860")]
		public void Awake()
		{
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A72C")]
		[Address(RVA = "0x32188B0", Offset = "0x32174B0", VA = "0x1832188B0")]
		public void Init()
		{
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A72D")]
		[Address(RVA = "0x3218B10", Offset = "0x3217710", VA = "0x183218B10")]
		public void Reset()
		{
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A72E")]
		[Address(RVA = "0x3218980", Offset = "0x3217580", VA = "0x183218980")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A72F")]
		[Address(RVA = "0x3218A20", Offset = "0x3217620", VA = "0x183218A20")]
		public void Play()
		{
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A730")]
		[Address(RVA = "0x3218D60", Offset = "0x3217960", VA = "0x183218D60")]
		private void _PlayInternal()
		{
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A731")]
		[Address(RVA = "0x3218D40", Offset = "0x3217940", VA = "0x183218D40")]
		public void Stop()
		{
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A732")]
		[Address(RVA = "0x3218C90", Offset = "0x3217890", VA = "0x183218C90")]
		public void SetTrigger(string triggerKey = "onInteract")
		{
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A733")]
		[Address(RVA = "0x32188A0", Offset = "0x32174A0", VA = "0x1832188A0")]
		public void FinishMe()
		{
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A734")]
		[Address(RVA = "0x3218E00", Offset = "0x3217A00", VA = "0x183218E00")]
		public BuildingEffect()
		{
		}

		// Token: 0x04009F5E RID: 40798
		[Token(Token = "0x4009F5E")]
		private const string EFFECT_TRIGGER_KEY = "onInteract";

		// Token: 0x04009F5F RID: 40799
		[Token(Token = "0x4009F5F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _predelay;

		// Token: 0x04009F60 RID: 40800
		[Token(Token = "0x4009F60")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _delayToFinish;

		// Token: 0x04009F61 RID: 40801
		[Token(Token = "0x4009F61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FP _playProbability;

		// Token: 0x04009F62 RID: 40802
		[Token(Token = "0x4009F62")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem m_particleSystem;

		// Token: 0x04009F63 RID: 40803
		[Token(Token = "0x4009F63")]
		[FieldOffset(Offset = "0x30")]
		private Animator m_animator;

		// Token: 0x04009F64 RID: 40804
		[Token(Token = "0x4009F64")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isPlaying;

		// Token: 0x04009F65 RID: 40805
		[Token(Token = "0x4009F65")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isPreDelay;

		// Token: 0x04009F66 RID: 40806
		[Token(Token = "0x4009F66")]
		[FieldOffset(Offset = "0x3A")]
		private bool m_isDelayToFinish;

		// Token: 0x04009F67 RID: 40807
		[Token(Token = "0x4009F67")]
		[FieldOffset(Offset = "0x3C")]
		private float m_delayToFinishTime;

		// Token: 0x04009F68 RID: 40808
		[Token(Token = "0x4009F68")]
		[FieldOffset(Offset = "0x40")]
		private float m_predelay;

		// Token: 0x04009F69 RID: 40809
		[Token(Token = "0x4009F69")]
		[FieldOffset(Offset = "0x48")]
		private string m_triggerkey;
	}
}
