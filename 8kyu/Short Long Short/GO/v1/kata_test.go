package kata_test

import (
	. "github.com/onsi/ginkgo"
	. "github.com/onsi/gomega"
	. "v1"
)

var _ = Describe("Tests", func() {
	It("Basic Tests", func() {
		Expect(Solution("45", "1")).To(Equal("1451"))
		Expect(Solution("13", "200")).To(Equal("1320013"))
		Expect(Solution("Soon", "Me")).To(Equal("MeSoonMe"))
		Expect(Solution("U", "False")).To(Equal("UFalseU"))
	})
})
