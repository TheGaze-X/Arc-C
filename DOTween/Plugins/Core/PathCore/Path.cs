using System;
using System.Runtime.InteropServices;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[Serializable]
	public class Path
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x1700000E")]
		internal int minInputWaypoints
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x374FA00", Offset = "0x374E600", VA = "0x18374FA00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x374F610", Offset = "0x374E210", VA = "0x18374F610")]
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, [Optional] Color? gizmoColor)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x374F9E0", Offset = "0x374E5E0", VA = "0x18374F9E0")]
		internal Path()
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x374EFF0", Offset = "0x374DBF0", VA = "0x18374EFF0")]
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x374F2F0", Offset = "0x374DEF0", VA = "0x18374F2F0")]
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false)
		{
			return default(Vector3);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x374E480", Offset = "0x374D080", VA = "0x18374E480")]
		internal float ConvertToConstantPathPerc(float perc)
		{
			return 0f;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x374F3C0", Offset = "0x374DFC0", VA = "0x18374F3C0")]
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward)
		{
			return 0;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x374F170", Offset = "0x374DD70", VA = "0x18374F170")]
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment)
		{
			return null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x374F460", Offset = "0x374E060", VA = "0x18374F460")]
		internal static void RefreshNonLinearDrawWps(Path p)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x374E6B0", Offset = "0x374D2B0", VA = "0x18374E6B0")]
		internal void Destroy()
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x374DDA0", Offset = "0x374C9A0", VA = "0x18374DDA0")]
		internal Path CloneIncremental(int loopIncrement)
		{
			return null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x374DCB0", Offset = "0x374C8B0", VA = "0x18374DCB0")]
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x374DAF0", Offset = "0x374C6F0", VA = "0x18374DAF0")]
		internal void AssignDecoder(PathType pathType)
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x374EFE0", Offset = "0x374DBE0", VA = "0x18374EFE0")]
		internal void Draw()
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x374E810", Offset = "0x374D410", VA = "0x18374E810")]
		private static void Draw(Path p)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x374E5C0", Offset = "0x374D1C0", VA = "0x18374E5C0")]
		private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions)
		{
			return default(Vector3);
		}

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CatmullRomDecoder _catmullRomDecoder;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static LinearDecoder _linearDecoder;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CubicBezierDecoder _cubicBezierDecoder;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] wpLengths;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Vector3[] wps;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal PathType type;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal int subdivisionsXSegment;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal int subdivisions;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal ControlPoint[] controlPoints;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal float length;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		internal bool isFinalized;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal float[] timesTable;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal float[] lengthsTable;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal int linearWPIndex;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal bool addedExtraStartWp;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		internal bool addedExtraEndWp;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal PathOptions plugOptions;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Path _incrementalClone;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _incrementalIndex;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ABSPathDecoder _decoder;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _changed;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal Vector3[] nonLinearDrawWps;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal Vector3 targetPosition;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		internal Vector3? lookAtPosition;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		internal Color gizmoColor;
	}
}
