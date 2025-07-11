c = [0] + gets.split.map(&:to_i)
x = Array.new(9, 0)

common_factor = c[1].gcd(c[5])
x[1] = c[1] / common_factor
x[3] = c[5] / common_factor
x[2] = c[1] / x[1]

common_factor = c[3].gcd(c[6])
x[7] = c[3] / common_factor
x[5] = c[6] / common_factor
x[6] = c[6] / x[5]

(1...9).each { |i| print "#{x[i]} " if x[i] > 0}