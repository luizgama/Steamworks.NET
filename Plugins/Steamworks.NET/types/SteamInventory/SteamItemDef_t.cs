// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2016 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// Changes to this file will be reverted when you update Steamworks.NET

namespace Steamworks {
	[System.Serializable]
	public struct SteamItemDef_t : System.IEquatable<SteamItemDef_t>, System.IComparable<SteamItemDef_t> {
		public int m_SteamItemDef;

		public SteamItemDef_t(int value) {
			m_SteamItemDef = value;
		}

		public override string ToString() {
			return m_SteamItemDef.ToString();
		}

		public override bool Equals(object other) {
			return other is SteamItemDef_t && this == (SteamItemDef_t)other;
		}

		public override int GetHashCode() {
			return m_SteamItemDef.GetHashCode();
		}

		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y) {
			return x.m_SteamItemDef == y.m_SteamItemDef;
		}

		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y) {
			return !(x == y);
		}

		public static explicit operator SteamItemDef_t(int value) {
			return new SteamItemDef_t(value);
		}

		public static explicit operator int(SteamItemDef_t that) {
			return that.m_SteamItemDef;
		}

		public bool Equals(SteamItemDef_t other) {
			return m_SteamItemDef == other.m_SteamItemDef;
		}

		public int CompareTo(SteamItemDef_t other) {
			return m_SteamItemDef.CompareTo(other.m_SteamItemDef);
		}
	}
}
