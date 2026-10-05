using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public abstract class Marker : ScriptableObject, IMarker
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000B9")]
		public TrackAsset parent
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000036EC File Offset: 0x000018EC
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000BA")]
		public double time
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x28615D0", Offset = "0x28601D0", VA = "0x1828615D0", Slot = "4")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x58EAB70", Offset = "0x58E9770", VA = "0x1858EAB70", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x58EAA70", Offset = "0x58E9670", VA = "0x1858EAA70", Slot = "7")]
		private void Initialize(TrackAsset parentTrack)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void OnInitialize(TrackAsset aPent)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected Marker()
		{
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Time for the marker")]
		[TimeField(TimeFieldAttribute.UseEditMode.ApplyEditMode)]
		private double m_Time;
	}
}
