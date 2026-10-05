using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	internal class VectorImageManager : IDisposable
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004AB")]
		public Texture2D atlas
		{
			[Token(Token = "0x6001310")]
			[Address(RVA = "0x5A67230", Offset = "0x5A65E30", VA = "0x185A67230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001311")]
		[Address(RVA = "0x5A66CF0", Offset = "0x5A658F0", VA = "0x185A66CF0")]
		public VectorImageManager(AtlasBase atlas)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00009FA8 File Offset: 0x000081A8
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AC")]
		private protected bool disposed
		{
			[Token(Token = "0x6001312")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6001313")]
			[Address(RVA = "0x3249520", Offset = "0x3248120", VA = "0x183249520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x5A66660", Offset = "0x5A65260", VA = "0x185A66660", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001315")]
		[Address(RVA = "0x5A66540", Offset = "0x5A65140", VA = "0x185A66540", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x5A66510", Offset = "0x5A65110", VA = "0x185A66510")]
		public void Commit()
		{
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x5A66410", Offset = "0x5A65010", VA = "0x185A66410")]
		public GradientRemap AddUser(VectorImage vi, VisualElement context)
		{
			return null;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001318")]
		[Address(RVA = "0x5A666D0", Offset = "0x5A652D0", VA = "0x185A666D0")]
		private VectorImageRenderInfo Register(VectorImage vi, VisualElement context)
		{
			return null;
		}

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x0")]
		public static List<VectorImageManager> instances;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker s_MarkerRegister;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker s_MarkerUnregister;

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		[FieldOffset(Offset = "0x10")]
		private readonly AtlasBase m_Atlas;

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0x20")]
		private VectorImageRenderInfoPool m_RenderInfoPool;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[FieldOffset(Offset = "0x28")]
		private GradientRemapPool m_GradientRemapPool;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0x30")]
		private GradientSettingsAtlas m_GradientSettingsAtlas;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x38")]
		private bool m_LoggedExhaustedSettingsAtlas;
	}
}
