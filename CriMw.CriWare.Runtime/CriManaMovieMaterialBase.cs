using System;
using System.Collections;
using System.Runtime.CompilerServices;
using CriWare.CriMana;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public abstract class CriManaMovieMaterialBase : CriMonoBehaviour
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00003F14 File Offset: 0x00002114
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008C")]
		public CriManaMovieMaterialBase.MaxFrameDrop maxFrameDrop
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return CriManaMovieMaterialBase.MaxFrameDrop.Disabled;
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x3700380", Offset = "0x36FEF80", VA = "0x183700380")]
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000738 RID: 1848
		[Token(Token = "0x1700008D")]
		protected abstract bool initializeWithAdvancedAudio { [Token(Token = "0x6000738")] get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000739 RID: 1849
		[Token(Token = "0x1700008E")]
		protected abstract bool initializeWithAmbisonics { [Token(Token = "0x6000739")] get; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00003F2C File Offset: 0x0000212C
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008F")]
		public bool isMaterialAvailable
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x37002B0", Offset = "0x36FEEB0", VA = "0x1837002B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x37002D0", Offset = "0x36FEED0", VA = "0x1837002D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000090")]
		public Player player
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000091")]
		public Material material
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x37002E0", Offset = "0x36FEEE0", VA = "0x1837002E0")]
			set
			{
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x36FF930", Offset = "0x36FE530", VA = "0x1836FF930")]
		private void DestroyOwnMaterial()
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00003F44 File Offset: 0x00002144
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000092")]
		public Player.TimerType timerType
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return Player.TimerType.None;
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x37003A0", Offset = "0x36FEFA0", VA = "0x1837003A0")]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000743 RID: 1859
		[Token(Token = "0x17000093")]
		protected abstract uint FilePathLength { [Token(Token = "0x6000743")] get; }

		// Token: 0x06000744 RID: 1860
		[Token(Token = "0x6000744")]
		protected abstract void SetDataToPlayer();

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00003F5C File Offset: 0x0000215C
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000094")]
		private protected bool HaveRendererOwner
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x37002A0", Offset = "0x36FEEA0", VA = "0x1837002A0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x37002C0", Offset = "0x36FEEC0", VA = "0x1837002C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x36FFCD0", Offset = "0x36FE8D0", VA = "0x1836FFCD0")]
		public void Play()
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x37001B0", Offset = "0x36FEDB0", VA = "0x1837001B0")]
		public void Stop()
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x36FFCA0", Offset = "0x36FE8A0", VA = "0x1836FFCA0")]
		public void Pause(bool sw)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		protected virtual void OnMaterialAvailableChanged()
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		protected virtual void OnMaterialUpdated()
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x36FF5E0", Offset = "0x36FE1E0", VA = "0x1836FF5E0")]
		public void PlayerManualInitialize()
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x36FFD20", Offset = "0x36FE920", VA = "0x1836FFD20")]
		public void PlayerManualFinalize()
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x36FFD90", Offset = "0x36FE990", VA = "0x1836FFD90")]
		public void PlayerManualSetup()
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public virtual bool RenderTargetManualSetup()
		{
			return default(bool);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void RenderTargetManualFinalize()
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x36FF860", Offset = "0x36FE460", VA = "0x1836FF860")]
		public void PlayerManualUpdate()
		{
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x36FF5E0", Offset = "0x36FE1E0", VA = "0x1836FF5E0", Slot = "16")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x36FFBA0", Offset = "0x36FE7A0", VA = "0x1836FFBA0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x36FFF40", Offset = "0x36FEB40", VA = "0x1836FFF40")]
		private IEnumerator RestartPlayerRoutine()
		{
			return null;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x36FFB10", Offset = "0x36FE710", VA = "0x1836FFB10", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x36FFA80", Offset = "0x36FE680", VA = "0x1836FFA80", Slot = "17")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x36FFFC0", Offset = "0x36FEBC0", VA = "0x1836FFFC0", Slot = "18")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x36FF860", Offset = "0x36FE460", VA = "0x1836FF860", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x36FFF10", Offset = "0x36FEB10", VA = "0x1836FFF10", Slot = "19")]
		public virtual void RenderMovie()
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x36FF830", Offset = "0x36FE430", VA = "0x1836FF830", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x36FFC70", Offset = "0x36FE870", VA = "0x1836FFC70", Slot = "20")]
		protected virtual void OnWillRenderObject()
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x36FF9F0", Offset = "0x36FE5F0", VA = "0x1836FF9F0")]
		private void OnApplicationPause(bool appPause)
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x36FF9F0", Offset = "0x36FE5F0", VA = "0x1836FF9F0")]
		private void ProcessApplicationPause(bool appPause)
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x36FF770", Offset = "0x36FE370", VA = "0x1836FF770")]
		private void CreateMaterial()
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x3700210", Offset = "0x36FEE10", VA = "0x183700210")]
		protected CriManaMovieMaterialBase()
		{
		}

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x28")]
		public bool playOnStart;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x29")]
		public bool restartOnEnable;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x38")]
		public CriManaMovieMaterialBase.RenderMode renderMode;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x40")]
		public CriManaMovieMaterialBase.OnApplicationPauseCallback onApplicationPauseCallback;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x48")]
		private Player.TimerType _timerType;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Material _material;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CriManaMovieMaterialBase.MaxFrameDrop _maxFrameDrop;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x5C")]
		private bool materialOwn;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x5D")]
		protected bool isMonoBehaviourStartCalled;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x5E")]
		private bool wasDisabled;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x5F")]
		private bool wasPausedOnDisable;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x60")]
		private bool previousOnApplicationPauseStatus;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x68")]
		private WaitForEndOfFrame frameEnd;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x70")]
		private bool unpauseOnApplicationUnpause;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x78")]
		private CriManaMoviePlayerHolder playerHolder;

		// Token: 0x020000D7 RID: 215
		[Token(Token = "0x20000D7")]
		public enum MaxFrameDrop
		{
			// Token: 0x040003ED RID: 1005
			[Token(Token = "0x40003ED")]
			Disabled,
			// Token: 0x040003EE RID: 1006
			[Token(Token = "0x40003EE")]
			One,
			// Token: 0x040003EF RID: 1007
			[Token(Token = "0x40003EF")]
			Two,
			// Token: 0x040003F0 RID: 1008
			[Token(Token = "0x40003F0")]
			Three,
			// Token: 0x040003F1 RID: 1009
			[Token(Token = "0x40003F1")]
			Four,
			// Token: 0x040003F2 RID: 1010
			[Token(Token = "0x40003F2")]
			Five,
			// Token: 0x040003F3 RID: 1011
			[Token(Token = "0x40003F3")]
			Six,
			// Token: 0x040003F4 RID: 1012
			[Token(Token = "0x40003F4")]
			Seven,
			// Token: 0x040003F5 RID: 1013
			[Token(Token = "0x40003F5")]
			Eight,
			// Token: 0x040003F6 RID: 1014
			[Token(Token = "0x40003F6")]
			Nine,
			// Token: 0x040003F7 RID: 1015
			[Token(Token = "0x40003F7")]
			Ten
		}

		// Token: 0x020000D8 RID: 216
		[Token(Token = "0x20000D8")]
		public enum RenderMode
		{
			// Token: 0x040003F9 RID: 1017
			[Token(Token = "0x40003F9")]
			Always,
			// Token: 0x040003FA RID: 1018
			[Token(Token = "0x40003FA")]
			OnVisibility,
			// Token: 0x040003FB RID: 1019
			[Token(Token = "0x40003FB")]
			Never
		}

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x06000761 RID: 1889
		[Token(Token = "0x20000D9")]
		public delegate void OnApplicationPauseCallback(CriManaMovieMaterialBase manaMovieMaterial, bool appPause);
	}
}
