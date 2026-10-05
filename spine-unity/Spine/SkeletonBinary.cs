using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class SkeletonBinary
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00003824 File Offset: 0x00001A24
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000113")]
		public float Scale
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x4E59F30", Offset = "0x4E58B30", VA = "0x184E59F30")]
		public SkeletonBinary(params Atlas[] atlasArray)
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x4E5A020", Offset = "0x4E58C20", VA = "0x184E5A020")]
		public SkeletonBinary(AttachmentLoader attachmentLoader)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x4E59550", Offset = "0x4E58150", VA = "0x184E59550")]
		public SkeletonData ReadSkeletonData(string path)
		{
			return null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x4E54BC0", Offset = "0x4E537C0", VA = "0x184E54BC0")]
		public static string GetVersionString(Stream file)
		{
			return null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x4E57680", Offset = "0x4E56280", VA = "0x184E57680")]
		public SkeletonData ReadSkeletonData(Stream file)
		{
			return null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x4E596B0", Offset = "0x4E582B0", VA = "0x184E596B0")]
		private Skin ReadSkin(SkeletonBinary.SkeletonInput input, SkeletonData skeletonData, bool defaultSkin, bool nonessential)
		{
			return null;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x4E56670", Offset = "0x4E55270", VA = "0x184E56670")]
		private Attachment ReadAttachment(SkeletonBinary.SkeletonInput input, SkeletonData skeletonData, Skin skin, int slotIndex, string attachmentName, bool nonessential)
		{
			return null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4E59B50", Offset = "0x4E58750", VA = "0x184E59B50")]
		private SkeletonBinary.Vertices ReadVertices(SkeletonBinary.SkeletonInput input, int vertexCount)
		{
			return null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x4E574C0", Offset = "0x4E560C0", VA = "0x184E574C0")]
		private float[] ReadFloatArray(SkeletonBinary.SkeletonInput input, int n, float scale)
		{
			return null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x4E575B0", Offset = "0x4E561B0", VA = "0x184E575B0")]
		private int[] ReadShortArray(SkeletonBinary.SkeletonInput input)
		{
			return null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x4E56590", Offset = "0x4E55190", VA = "0x184E56590")]
		public Animation ReadAnimation(Animation anim, byte[] buffer, SkeletonData skeletonData, ExposedList<string> strings)
		{
			return null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x4E54C80", Offset = "0x4E53880", VA = "0x184E54C80")]
		private Animation ReadAnimation(string name, SkeletonBinary.SkeletonInput input, SkeletonData skeletonData)
		{
			return null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x4E573D0", Offset = "0x4E55FD0", VA = "0x184E573D0")]
		private void ReadCurve(SkeletonBinary.SkeletonInput input, int frameIndex, CurveTimeline timeline)
		{
		}

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		public const int BONE_ROTATE = 0;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		public const int BONE_TRANSLATE = 1;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		public const int BONE_SCALE = 2;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		public const int BONE_SHEAR = 3;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		public const int SLOT_ATTACHMENT = 0;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		public const int SLOT_COLOR = 1;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		public const int SLOT_TWO_COLOR = 2;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		public const int PATH_POSITION = 0;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		public const int PATH_SPACING = 1;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		public const int PATH_MIX = 2;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		public const int CURVE_LINEAR = 0;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		public const int CURVE_STEPPED = 1;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		public const int CURVE_BEZIER = 2;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x18")]
		private AttachmentLoader attachmentLoader;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x20")]
		private List<SkeletonJson.LinkedMesh> linkedMeshes;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TransformMode[] TransformModeValues;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x8")]
		public static bool useLazyLoad;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		internal class Vertices
		{
			// Token: 0x0600037B RID: 891 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Vertices()
			{
			}

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x10")]
			public int[] bones;

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x18")]
			public float[] vertices;
		}

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		internal class SkeletonInput
		{
			// Token: 0x0600037C RID: 892 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x4E63720", Offset = "0x4E62320", VA = "0x184E63720")]
			public SkeletonInput(Stream input)
			{
			}

			// Token: 0x0600037D RID: 893 RVA: 0x0000383C File Offset: 0x00001A3C
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x4E63090", Offset = "0x4E61C90", VA = "0x184E63090")]
			public byte ReadByte()
			{
				return 0;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00003854 File Offset: 0x00001A54
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x4E63540", Offset = "0x4E62140", VA = "0x184E63540")]
			public sbyte ReadSByte()
			{
				return 0;
			}

			// Token: 0x0600037F RID: 895 RVA: 0x0000386C File Offset: 0x00001A6C
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x4E63040", Offset = "0x4E61C40", VA = "0x184E63040")]
			public bool ReadBoolean()
			{
				return default(bool);
			}

			// Token: 0x06000380 RID: 896 RVA: 0x00003884 File Offset: 0x00001A84
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x4E630E0", Offset = "0x4E61CE0", VA = "0x184E630E0")]
			public float ReadFloat()
			{
				return 0f;
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0000389C File Offset: 0x00001A9C
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x4E63480", Offset = "0x4E62080", VA = "0x184E63480")]
			public int ReadInt()
			{
				return 0;
			}

			// Token: 0x06000382 RID: 898 RVA: 0x000038B4 File Offset: 0x00001AB4
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x4E63330", Offset = "0x4E61F30", VA = "0x184E63330")]
			public int ReadInt(bool optimizePositive)
			{
				return 0;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x4E63630", Offset = "0x4E62230", VA = "0x184E63630")]
			public string ReadString()
			{
				return null;
			}

			// Token: 0x06000384 RID: 900 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x4E635D0", Offset = "0x4E621D0", VA = "0x184E635D0")]
			public string ReadStringRef()
			{
				return null;
			}

			// Token: 0x06000385 RID: 901 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x4E63250", Offset = "0x4E61E50", VA = "0x184E63250")]
			public void ReadFully(byte[] buffer, int offset, int length)
			{
			}

			// Token: 0x06000386 RID: 902 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x4E62DB0", Offset = "0x4E619B0", VA = "0x184E62DB0")]
			public string GetVersionString()
			{
				return null;
			}

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			[FieldOffset(Offset = "0x10")]
			private byte[] chars;

			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			[FieldOffset(Offset = "0x18")]
			private byte[] bytesBigEndian;

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x20")]
			internal ExposedList<string> strings;

			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x28")]
			internal Stream input;
		}
	}
}
