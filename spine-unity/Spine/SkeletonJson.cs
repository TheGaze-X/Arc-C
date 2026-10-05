using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public class SkeletonJson
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00003AF4 File Offset: 0x00001CF4
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000135")]
		public float Scale
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x4E6FD20", Offset = "0x4E6E920", VA = "0x184E6FD20")]
		public SkeletonJson(params Atlas[] atlasArray)
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x4E6FC10", Offset = "0x4E6E810", VA = "0x184E6FC10")]
		public SkeletonJson(AttachmentLoader attachmentLoader)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x4E6AA30", Offset = "0x4E69630", VA = "0x184E6AA30")]
		public SkeletonData ReadSkeletonData(string path)
		{
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x4E6ABC0", Offset = "0x4E697C0", VA = "0x184E6ABC0")]
		public SkeletonData ReadSkeletonData(TextReader reader)
		{
			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x4E69250", Offset = "0x4E67E50", VA = "0x184E69250")]
		private Attachment ReadAttachment(Dictionary<string, object> map, Skin skin, int slotIndex, string name, SkeletonData skeletonData)
		{
			return null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x4E6F7F0", Offset = "0x4E6E3F0", VA = "0x184E6F7F0")]
		private void ReadVertices(Dictionary<string, object> map, VertexAttachment attachment, int verticesLength)
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x4E63EC0", Offset = "0x4E62AC0", VA = "0x184E63EC0")]
		private void ReadAnimation(Dictionary<string, object> map, string name, SkeletonData skeletonData)
		{
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x4E6A840", Offset = "0x4E69440", VA = "0x184E6A840")]
		private static void ReadCurve(Dictionary<string, object> valueMap, CurveTimeline timeline, int frameIndex)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x4E63890", Offset = "0x4E62490", VA = "0x184E63890")]
		private static float[] GetFloatArray(Dictionary<string, object> map, string name, float scale)
		{
			return null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x4E63B80", Offset = "0x4E62780", VA = "0x184E63B80")]
		private static int[] GetIntArray(Dictionary<string, object> map, string name)
		{
			return null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x4E63AB0", Offset = "0x4E626B0", VA = "0x184E63AB0")]
		private static float GetFloat(Dictionary<string, object> map, string name, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x4E63D20", Offset = "0x4E62920", VA = "0x184E63D20")]
		private static int GetInt(Dictionary<string, object> map, string name, int defaultValue)
		{
			return 0;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x4E637B0", Offset = "0x4E623B0", VA = "0x184E637B0")]
		private static bool GetBoolean(Dictionary<string, object> map, string name, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x4E63DF0", Offset = "0x4E629F0", VA = "0x184E63DF0")]
		private static string GetString(Dictionary<string, object> map, string name, string defaultValue)
		{
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x4E6FAD0", Offset = "0x4E6E6D0", VA = "0x184E6FAD0")]
		private static float ToColor(string hexString, int colorIndex, int expectedLength = 8)
		{
			return 0f;
		}

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x18")]
		private AttachmentLoader attachmentLoader;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x20")]
		private List<SkeletonJson.LinkedMesh> linkedMeshes;

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		internal class LinkedMesh
		{
			// Token: 0x060003F2 RID: 1010 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x4E5F540", Offset = "0x4E5E140", VA = "0x184E5F540")]
			public LinkedMesh(MeshAttachment mesh, string skin, int slotIndex, string parent, bool inheritDeform)
			{
			}

			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			[FieldOffset(Offset = "0x10")]
			internal string parent;

			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x18")]
			internal string skin;

			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			[FieldOffset(Offset = "0x20")]
			internal int slotIndex;

			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			[FieldOffset(Offset = "0x28")]
			internal MeshAttachment mesh;

			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			[FieldOffset(Offset = "0x30")]
			internal bool inheritDeform;
		}
	}
}
