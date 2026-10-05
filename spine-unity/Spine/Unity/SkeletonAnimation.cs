using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonAnimation-Component")]
	[ExecuteAlways]
	[AddComponentMenu("Spine/SkeletonAnimation")]
	public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation, IAnimationStateComponent
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000042A4 File Offset: 0x000024A4
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000194")]
		public bool EnableManualUpdate
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x42BAC50", Offset = "0x42B9850", VA = "0x1842BAC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x42BAC70", Offset = "0x42B9870", VA = "0x1842BAC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000042BC File Offset: 0x000024BC
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000195")]
		public bool cacheFixedBoundsCenterOnce
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x4E7EAB0", Offset = "0x4E7D6B0", VA = "0x184E7EAB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x4E7EE70", Offset = "0x4E7DA70", VA = "0x184E7EE70")]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000196")]
		public AnimationState AnimationState
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x4E7EA70", Offset = "0x4E7D670", VA = "0x184E7EA70", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000544 RID: 1348 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000545 RID: 1349 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400000E")]
		protected event UpdateBonesDelegate _BeforeApply
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x4E7E790", Offset = "0x4E7D390", VA = "0x184E7E790")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x4E7EAC0", Offset = "0x4E7D6C0", VA = "0x184E7EAC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000546 RID: 1350 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000547 RID: 1351 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400000F")]
		protected event UpdateBonesDelegate _UpdateLocal
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x4E7E8D0", Offset = "0x4E7D4D0", VA = "0x184E7E8D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x4E7EC00", Offset = "0x4E7D800", VA = "0x184E7EC00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000548 RID: 1352 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000549 RID: 1353 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000010")]
		protected event UpdateBonesDelegate _UpdateWorld
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x4E7E970", Offset = "0x4E7D570", VA = "0x184E7E970")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x4E7ECA0", Offset = "0x4E7D8A0", VA = "0x184E7ECA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600054A RID: 1354 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600054B RID: 1355 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000011")]
		protected event UpdateBonesDelegate _UpdateComplete
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x4E7E830", Offset = "0x4E7D430", VA = "0x184E7E830")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x4E7EB60", Offset = "0x4E7D760", VA = "0x184E7EB60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600054C RID: 1356 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600054D RID: 1357 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000012")]
		public event UpdateBonesDelegate BeforeApply
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x4E7E790", Offset = "0x4E7D390", VA = "0x184E7E790")]
			add
			{
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x4E7EAC0", Offset = "0x4E7D6C0", VA = "0x184E7EAC0")]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600054E RID: 1358 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600054F RID: 1359 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000013")]
		public event UpdateBonesDelegate UpdateLocal
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x4E7E8D0", Offset = "0x4E7D4D0", VA = "0x184E7E8D0", Slot = "11")]
			add
			{
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x4E7EC00", Offset = "0x4E7D800", VA = "0x184E7EC00", Slot = "12")]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000550 RID: 1360 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000551 RID: 1361 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000014")]
		public event UpdateBonesDelegate UpdateWorld
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x4E7E970", Offset = "0x4E7D570", VA = "0x184E7E970", Slot = "13")]
			add
			{
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x4E7ECA0", Offset = "0x4E7D8A0", VA = "0x184E7ECA0", Slot = "14")]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000552 RID: 1362 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x06000553 RID: 1363 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x14000015")]
		public event UpdateBonesDelegate UpdateComplete
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x4E7E830", Offset = "0x4E7D430", VA = "0x184E7E830", Slot = "15")]
			add
			{
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x4E7EB60", Offset = "0x4E7D760", VA = "0x184E7EB60", Slot = "16")]
			remove
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000197")]
		public string AnimationName
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x4E7EA10", Offset = "0x4E7D610", VA = "0x184E7EA10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x4E7ED40", Offset = "0x4E7D940", VA = "0x184E7ED40")]
			set
			{
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
		public void TorappuOnly_SetRawAnimationName(string animationName)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x4E7E0C0", Offset = "0x4E7CCC0", VA = "0x184E7E0C0")]
		public static SkeletonAnimation AddToGameObject(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, bool quiet = false)
		{
			return null;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x4E7E4A0", Offset = "0x4E7D0A0", VA = "0x184E7E4A0")]
		public static SkeletonAnimation NewSkeletonAnimationGameObject(SkeletonDataAsset skeletonDataAsset, bool quiet = false)
		{
			return null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x4E7E230", Offset = "0x4E7CE30", VA = "0x184E7E230", Slot = "8")]
		public override void ClearState()
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x4E7E300", Offset = "0x4E7CF00", VA = "0x184E7E300", Slot = "9")]
		public override void Initialize(bool overwrite, bool quiet = false)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x4E7E580", Offset = "0x4E7D180", VA = "0x184E7E580")]
		private void Update()
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x4E7E5C0", Offset = "0x4E7D1C0", VA = "0x184E7E5C0")]
		public void Update(float deltaTime)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x4E7E520", Offset = "0x4E7D120", VA = "0x184E7E520")]
		protected void UpdateAnimationStatus(float deltaTime)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x4E7E140", Offset = "0x4E7CD40", VA = "0x184E7E140")]
		protected void ApplyAnimation()
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x4E7E450", Offset = "0x4E7D050", VA = "0x184E7E450", Slot = "10")]
		public override void LateUpdate()
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x4E7E730", Offset = "0x4E7D330", VA = "0x184E7E730")]
		public SkeletonAnimation()
		{
		}

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0xF8")]
		public AnimationState state;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x100")]
		private bool wasUpdatedAfterInit;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[SpineAnimation("", "", true, false)]
		private string _animationName;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x130")]
		public bool loop;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x134")]
		public float timeScale;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x138")]
		private bool m_cacheFixedBoundsCenterOnce;
	}
}
